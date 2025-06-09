using UnityEngine;
using UnityEngine.UI;    // UI ���ӽ����̽�
using System;
using TMPro;

[Serializable]
public class CommandPlayer : MonoBehaviour
{
    [Header("Inspector���� ����")]
    public TMP_InputField commandInput;
    public Button playButton;        // UI �� PlayButton �Ҵ�
    public Animator animator;        // �ִϸ����� �Ҵ�

    void Start()
    {
        Debug.Log($"[CmdPlayer] Animator: {animator}");
        Debug.Log($"[CmdPlayer] Controller: {animator.runtimeAnimatorController.name}");
        Debug.Log($"[CmdPlayer] LayerCount: {animator.layerCount}");
        for (int i = 0; i < animator.layerCount; i++)
            Debug.Log($"[CmdPlayer] Layer {i}: {animator.GetLayerName(i)}");

        // (����) ��ư �̺�Ʈ ����
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }


    void OnPlayButtonClicked()
    {
        string cmd = commandInput.text.Trim();
        if (string.IsNullOrEmpty(cmd)) return;

        int layer = 0;
        int hash = Animator.StringToHash(cmd);

        if (animator.HasState(layer, hash))
        {
            // �� State �̸�(cmd)���� �ٷ� Play
            animator.Play(cmd, layer, 0f);
            Debug.Log($"State '{cmd}' ���");
        }
        else
        {
            Debug.LogWarning($"State '{cmd}'��(��) ã�� �� �����ϴ�.");
        }
    }

}
