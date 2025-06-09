using UnityEngine;

public class HeadController : MonoBehaviour
{
    public Transform headJoint; // <- ����!
    public UdpReceiver receiver;

    void Update()
    {
        if (receiver.keypoints.Count >= 33 * 3) // Pose 33�� ��ǥ
        {
            Vector3 headPos = new Vector3(
                receiver.keypoints[0 * 3],
                receiver.keypoints[0 * 3 + 1],
                receiver.keypoints[0 * 3 + 2]
            );

            headJoint.localPosition = headPos * 2f;
        }
    }
}
