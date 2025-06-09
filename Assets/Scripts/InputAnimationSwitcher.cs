using UnityEngine;

public class InputAnimationSwitcher : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // �����̽��ٸ� ������ button = true �� feel_2_mp4_Armature ��ȯ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("button", true);
        }
        // �����̽��ٰ� �ƴ� �ٸ� Ű�� ������ button = false �� �⺻ ���·� ����
        else if (Input.anyKeyDown)
        {
            anim.SetBool("button", false);
        }
    }
}
