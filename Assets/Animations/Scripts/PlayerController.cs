using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    int isWalkingHash;
    void Start()
    {
        anim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    
    void FixedUpdate()
    {
        PlayerAnim();
        
    }

    void PlayerAnim()
    {
        bool isWalking = anim.GetBool(isWalkingHash);
        
        bool Wpress = Input.GetKey(KeyCode.W);
        if (!isWalking && Wpress)
        {
            anim.SetBool("isWalking", true);
        }
        if(isWalking && !Wpress)
        {
            anim.SetBool("isWalking", false);
        }
        
    }
}
