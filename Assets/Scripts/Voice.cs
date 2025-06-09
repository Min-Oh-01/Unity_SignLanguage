using System.Runtime.InteropServices;
using UnityEngine;

[RequireComponent(typeof(VoiceControlledAnimator))]
public class Voice : MonoBehaviour
{
    VoiceControlledAnimator vca;

    // WebGL ���� �ܺ� �Լ� ����
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void StartSpeechRecognition();
#endif

    void Awake()
    {
        vca = GetComponent<VoiceControlledAnimator>();
    }

    // �� Start() ��� �� �޼��带 ��ư Ŭ�� �� ȣ�� ��
    public void StartRecognition()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        StartSpeechRecognition();
        Debug.Log("�� WebGL �����ν� ���� (��ư Ŭ��)");
#else
        Debug.Log("�� Editor/Standalone ��� (�����ν� �̽���)");
#endif
    }

    // jslib���� SendMessage�� ȣ��˴ϴ�.
    public void OnRecognized(string text)
    {
        Debug.Log("Unity OnRecognized: " + text);
        vca.OnVoiceCommand(text);
    }
}

