using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

public class SkeletonPlayer : MonoBehaviour
{
    public TextAsset jsonFile;
    public GameObject jointPrefab;  // ���� ��ü ������
    public Material lineMaterial;

    private MotionData motionData;
    private Dictionary<string, GameObject> jointMap = new Dictionary<string, GameObject>();
    private List<(string, string)> boneConnections = new List<(string, string)>
    {
        ("mixamorig2:LeftShoulder", "mixamorig2:LeftArm"),
        ("mixamorig2:LeftArm", "mixamorig2:LeftForeArm"),
        ("mixamorig2:LeftForeArm", "mixamorig2:LeftHand"),
        ("mixamorig2:RightShoulder", "mixamorig2:RightArm"),
        ("mixamorig2:RightArm", "mixamorig2:RightForeArm"),
        ("mixamorig2:RightForeArm", "mixamorig2:RightHand"),
        // �հ���, �� �� �ʿ��� ��ŭ �߰�
    };

    private List<LineRenderer> lines = new List<LineRenderer>();
    private int currentFrame = 0;
    private float frameRate = 30f;
    private float timer = 0f;

    void Start()
    {
        motionData = JsonConvert.DeserializeObject<MotionData>(jsonFile.text);
        var initialFrame = motionData.frames[0];

        // Joint ����
        foreach (var joint in initialFrame.joints)
        {
            GameObject go = Instantiate(jointPrefab, Vector3.zero, Quaternion.identity, transform);
            go.name = joint.Key;
            jointMap[joint.Key] = go;
        }

        // Bone ���� ���� ����
        foreach (var pair in boneConnections)
        {
            var line = new GameObject("Line").AddComponent<LineRenderer>();
            line.material = lineMaterial;
            line.widthMultiplier = 0.02f;
            line.positionCount = 2;
            lines.Add(line);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f / frameRate)
        {
            timer = 0f;
            ApplyFrame(motionData.frames[currentFrame]);
            currentFrame = (currentFrame + 1) % motionData.frames.Count;
        }
    }

    void ApplyFrame(JointFrame frame)
    {
        foreach (var joint in frame.joints)
        {
            if (jointMap.ContainsKey(joint.Key))
            {
                Vector3 pos = new Vector3(-joint.Value[0], joint.Value[1], -joint.Value[2]);
                jointMap[joint.Key].transform.localPosition = pos;
            }
        }

        for (int i = 0; i < boneConnections.Count; i++)
        {
            var (a, b) = boneConnections[i];
            if (jointMap.ContainsKey(a) && jointMap.ContainsKey(b))
            {
                lines[i].SetPosition(0, jointMap[a].transform.position);
                lines[i].SetPosition(1, jointMap[b].transform.position);
            }
        }
    }
}
