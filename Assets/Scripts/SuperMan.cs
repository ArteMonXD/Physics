using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    public float pushPower;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            Rigidbody badGuyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = collision.transform.position - transform.position;
            badGuyRB.AddForce(direction * pushPower, ForceMode.Impulse);
        }
    }
}
