using UnityEngine;

public class CanvasAutoHide3s : MonoBehaviour
{
    [SerializeField] private Canvas canvasToHide;

    void Start()
    {
        // ���� �� 3�� �ڿ� HideCanvas() ȣ��
        Invoke(nameof(HideCanvas), 3f);
    }

    private void HideCanvas()
    {
        if (canvasToHide != null)
            canvasToHide.gameObject.SetActive(false);
        else
            Debug.LogWarning("canvasToHide�� �Ҵ���� �ʾҽ��ϴ�.");
    }
}
