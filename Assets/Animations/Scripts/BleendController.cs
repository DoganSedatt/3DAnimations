using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleendController : MonoBehaviour
{
    Animator anim;
    float velocity;
    public float acceleration = 0.6f;
    public float deceleration = 0.7f;
    int velocityHash;
    void Start()
    {
        anim = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Velocity");
    }

    
    void Update()
    {
        bool forwardPress = Input.GetKey("w");
        bool runPress = Input.GetKey("left shift");

        if (forwardPress&&velocity<1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!forwardPress&&velocity>0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }
        if (!forwardPress && velocity < 0.0f)
        {
            velocity = 0f; 
        }
        anim.SetFloat(velocityHash, velocity);
    }
}
