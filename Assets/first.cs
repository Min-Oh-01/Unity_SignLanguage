using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class first : MonoBehaviour
{
    [SerializeField] Animator animatorFirst;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space ���� �� sayHello");
            animatorFirst.SetTrigger("sayHello");
        }
    }
}