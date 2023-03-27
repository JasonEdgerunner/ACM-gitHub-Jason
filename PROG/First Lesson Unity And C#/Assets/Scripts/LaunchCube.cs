using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaunchCube : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        // Aka, for my own sake, this means that your Rigidbody + script gets called at the start of the playscene.
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            // Aka, for my own sake, pressing space will make the transform.up (the jump) be multiplied by the thrust. The longer you hold, the harder it goes!
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
    }
}