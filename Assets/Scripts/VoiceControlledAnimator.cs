using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class VoiceControlledAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space ���� �� sayHello");
            animator.SetTrigger("sayHello");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W ���� �� sayWhere");
            animator.SetTrigger("sayWhere");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S ���� �� saySick");
            animator.SetTrigger("saySick");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H ���� �� sayWhen");
            animator.SetTrigger("sayWhen");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F ���� �� sayFrom");
            animator.SetTrigger("sayFrom");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E ���� �� sayExamine");
            animator.SetTrigger("sayExamine");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T ���� �� sayStart");
            animator.SetTrigger("sayStart");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(" M���� �� sayMedicine");
            animator.SetTrigger("sayMedicine");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(" A���� �� sayEat");
            animator.SetTrigger("sayEat");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log(" N���� �� sayFinish");
            animator.SetTrigger("sayFinish");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(" C���� �� sayNeck");
            animator.SetTrigger("sayNeck");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(" B���� �� sayBoom");
            animator.SetTrigger("sayBoom");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log(" O���� �� sayHot");
            animator.SetTrigger("sayHot");
        }
    }


    public void OnVoiceCommand(string text)
    {
        if (text.Contains("�ȳ��ϼ���") || text.Contains("�ȳ�"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayHello");     // �� SetFloat �� SetTrigger
        }
        else if (text.Contains("���"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayWhere");
        }
        else if (text.Contains("����") || text.Contains("����"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("saySick");
        }
        else if (text.Contains("����"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayWhen");
        }
        else if (text.Contains("����"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayFrom");
        }
        else if (text.Contains("����") || text.Contains("����")
            || text.Contains("����") || text.Contains("����"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayExamine");
        }
        else if (text.Contains("����"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayStart");
        }
        else if (text.Contains("��"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayMedicine");
        }
        else if (text.Contains("�Դ�") || text.Contains("�弼��"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayEat");
        }
        else if (text.Contains("��ġ��") || text.Contains("������"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayFinish");
        }
        else if (text.Contains("��"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayNeck");
        }
        else if (text.Contains("�ξ�"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayBoom");
        }
        else if (text.Contains("������") || text.Contains("�����ϴ�")
    || text.Contains("�̴߰�") || text.Contains("�߰ſ�"))
        {
            Debug.Log($"�� OnVoiceCommand ȣ���: {text}");
            animator.SetTrigger("sayHot");
        }
    }


    IEnumerator ResetParam(string paramName, float delay)
    {
        yield return new WaitForSeconds(delay);
        animator.SetFloat(paramName, 0f);
    }
}