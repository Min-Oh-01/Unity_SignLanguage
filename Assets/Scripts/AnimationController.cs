using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // React(WebGL)���� ȣ���� �޼���
    public void SetTrigger(string triggerName)
    {
        animator.ResetTrigger(triggerName);
        animator.SetTrigger(triggerName);
    }

    public void SetBool(string paramName, bool value)
    {
        animator.SetBool(paramName, value);
    }

    // �����Ϳ��� �ٷ� �����غ� ContextMenu ����
    [ContextMenu("Play HelloAnim")]
    private void PlayHelloAnim()
    {
        SetTrigger("Play_�ȳ��ϼ���");
    }

    // ��Ÿ�� Ű �׽�Ʈ ����
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetTrigger("Play_�ȳ��ϼ���");
    }
}
