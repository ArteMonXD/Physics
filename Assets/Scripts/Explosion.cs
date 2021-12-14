using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float powerExplosion;
    private SphereCollider sphereCollider;
    public List<Rigidbody> explosiedObjects = new List<Rigidbody>();
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }
    
    public void Boom()
    {
        foreach(Rigidbody rb in explosiedObjects)
        {
            float distance = Vector3.Distance(transform.position, rb.transform.position);
            Vector3 direction = transform.position - rb.transform.position;
            rb.AddForce(direction.normalized * (powerExplosion * (sphereCollider.radius - distance)), ForceMode.Impulse);
        }
    }
}
