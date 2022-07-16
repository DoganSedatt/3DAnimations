using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleendFreeroam : MonoBehaviour
{
    Animator anim;
    float velocityZ;
    float velocityX;
    float acceleration = 2.0f;
    float deceleration = 2.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalkPress = Input.GetKey("w");
        bool isLeftPress = Input.GetKey("a");
        bool isRightPress = Input.GetKey("d");
        bool isBackPress = Input.GetKey("s");
        bool isRunPress = Input.GetKey("left shift");
        
        //-------------------------------------------//

        //*********************//
        //Ýleri Hareket Kodlarý//
        if (isWalkPress && velocityZ < 0.5f)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        if (isWalkPress && isRunPress && velocityZ < 2.0f)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        if (isWalkPress&&!isRunPress&&velocityZ>0.5f)
        {
            velocityZ -= Time.deltaTime * deceleration;
        }
        if (!isWalkPress&& velocityZ>0)
        {
            velocityZ -= Time.deltaTime * deceleration;
        }
        //Ýleri Hareket Kodlarý//
        //*********************//



        //*******************//
        //Sol Hareket Kodlarý//
        if (isLeftPress && velocityX >-0.5f)
        {
            velocityX -= Time.deltaTime * acceleration;
        }
        if (!isLeftPress && velocityX<0)
        {
            velocityX += Time.deltaTime * deceleration;
        }
        if (isLeftPress && isRunPress&& velocityX>-2.0f)
        {
            velocityX -= Time.deltaTime * acceleration;
        }
        if (isLeftPress && !isRunPress && velocityX<-0.5f)
        {
            velocityX += Time.deltaTime * deceleration;
        }
        //Sol Hareket Kodlarý//
        //*******************//


        //*******************//
        //Sað Hareket Kodlarý//
        if (isRightPress && velocityX < 0.5f)
        {
            velocityX += Time.deltaTime * acceleration;
        }
        if (!isRightPress && velocityX > 0)
        {
            velocityX -= Time.deltaTime * deceleration;
        }
        if (isRightPress && isRunPress && velocityX < 2.0f)
        {
            velocityX += Time.deltaTime * acceleration;
        }
        if (isRightPress && !isRunPress && velocityX > 0.5f)
        {
            velocityX -= Time.deltaTime * deceleration;
        }
        //Sað Hareket Kodlarý//
        //*******************//


        anim.SetFloat("Velocity Z", velocityZ);
        anim.SetFloat("Velocity X", velocityX);
    }
}
