using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Explosion"))
        {
            Explosion explosion = other.gameObject.GetComponent<Explosion>();
            explosion.explosiedObjects.Add(GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Explosion"))
        {
            Explosion explosion = other.gameObject.GetComponent<Explosion>();
            explosion.explosiedObjects.Remove(GetComponent<Rigidbody>());
        }
    }
}
