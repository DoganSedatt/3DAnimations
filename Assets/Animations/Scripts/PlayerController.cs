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
        bool isWalking = anim.GetBool(isWalkingHash);//Y�r�me durumunu kontrol ediyor.True veya false de�er veriyor.
        bool isRunning = anim.GetBool(isRunningHash);//Ko�ma durumunu kontrol ediyor.True veya false de�er veriyor.

        bool shiftPress = Input.GetKey(KeyCode.LeftShift);//Sol shifte bas�l�p bas�lmad���n� kontrol ediyor.
        bool Wpress = Input.GetKey(KeyCode.W);//W tu�una bas�l�p bas�lmad���n� kontrol ediyor.

        if (!isWalking && Wpress)//Y�r�m�yor ve W(Y�r�me) tu�una bas�l�yorsa;
        {
            anim.SetBool("isWalking", true);
            //Y�r�me animasyonunu �al��t�r.
        }
        if(isWalking && !Wpress)//Y�r�yor ve W(Y�r�me) tu�una bas�lm�yorsa;
        {
            anim.SetBool("isWalking", false);
            //Y�r�me animasyonunu durdur.
        }
        if(isWalking && shiftPress)//Y�r�yor ve shift(Ko�ma) tu�una bas�l�yorsa;
        {
            anim.SetBool("isRunning", true);
            //Ko�ma animasyonunu �al��t�r.
        }
        if(isRunning&& !shiftPress)//Ko�uyor ve shift(Ko�ma) tu�una bas�lm�yorsa;
        {
            anim.SetBool("isRunning", false);
            //Ko�ma animasyonunu durdur.
        }
        if (isRunning && !Wpress)//Ko�uyor ve W(Y�r�me) tu�una bas�lm�yorsa;
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            //Y�r�me ve ko�ma animasyonunu durdur. Bekleme(Idle) animasyonuna ge�er.
        }
        {

        }
        
    }
}
