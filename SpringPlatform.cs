using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;

public class SpringPlatform : MonoBehaviour
{
    [SerializeField] private int jumpForce;

    private float previousJumpForce;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previousJumpForce = fps.m_JumpSpeed;
                        
            fps.m_JumpSpeed += jumpForce;
            fps.m_Jump = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {            
            fps.m_JumpSpeed = previousJumpForce;
        }
    }
}
