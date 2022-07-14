using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    int isWalkingHash;
    int isRunningHash;
    void Start()
    {
        anim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    
    void FixedUpdate()
    {
        PlayerAnim();
    }

    void PlayerAnim()
    {
        bool isWalking = anim.GetBool(isWalkingHash);//Yürüme durumunu kontrol ediyor.True veya false deðer veriyor.
        bool isRunning = anim.GetBool(isRunningHash);//Koþma durumunu kontrol ediyor.True veya false deðer veriyor.

        bool shiftPress = Input.GetKey(KeyCode.LeftShift);//Sol shifte basýlýp basýlmadýðýný kontrol ediyor.
        bool Wpress = Input.GetKey(KeyCode.W);//W tuþuna basýlýp basýlmadýðýný kontrol ediyor.

        if (!isWalking && Wpress)//Yürümüyor ve W(Yürüme) tuþuna basýlýyorsa;
        {
            anim.SetBool("isWalking", true);
            //Yürüme animasyonunu çalýþtýr.
        }
        if(isWalking && !Wpress)//Yürüyor ve W(Yürüme) tuþuna basýlmýyorsa;
        {
            anim.SetBool("isWalking", false);
            //Yürüme animasyonunu durdur.
        }
        if(isWalking && shiftPress)//Yürüyor ve shift(Koþma) tuþuna basýlýyorsa;
        {
            anim.SetBool("isRunning", true);
            //Koþma animasyonunu çalýþtýr.
        }
        if(isRunning&& !shiftPress)//Koþuyor ve shift(Koþma) tuþuna basýlmýyorsa;
        {
            anim.SetBool("isRunning", false);
            //Koþma animasyonunu durdur.
        }
        if (isRunning && !Wpress)//Koþuyor ve W(Yürüme) tuþuna basýlmýyorsa;
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            //Yürüme ve koþma animasyonunu durdur. Bekleme(Idle) animasyonuna geçer.
        }
        {

        }
        
    }
}
