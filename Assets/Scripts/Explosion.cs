using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float powerExplosion;
    public float radius;
    private Rigidbody[] explosiveRb;
    void Start()
    {
        explosiveRb = FindObjectsOfType<Rigidbody>();
    }
    
    public void Boom()
    {
        foreach(Rigidbody rb in explosiveRb)
        {
            float distance = Vector3.Distance(transform.position, rb.transform.position);
            if(distance <= radius)
            {
                Vector3 direction = rb.transform.position - transform.position;
                rb.AddForce(direction.normalized * (powerExplosion * (radius - distance)), ForceMode.Impulse);
            }
        }
    }
}
