using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    public float punchPower;
    private Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    public void Punch()
    {
        rigidBody.AddForce(Vector3.forward * punchPower, ForceMode.Impulse);
    }
}
