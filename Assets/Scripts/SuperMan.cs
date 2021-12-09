using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    public float pushPower;
    public float sensitivityHor = 9.0f;
    public float speedMove = 10.0f;
    private void Update()
    {
        RotateControll();
        MoveControll();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            Rigidbody badGuyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = collision.transform.position - transform.position;
            badGuyRB.AddForce(direction * pushPower, ForceMode.Impulse);
        }
    }
    private void RotateControll()
    {
        transform.Rotate(0, (Input.GetAxis("Mouse X") * sensitivityHor) * Time.deltaTime, 0);
    }
    private void MoveControll()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            float deltaZ = Input.GetAxis("Vertical") * speedMove;
            transform.Translate(0, 0, deltaZ * Time.deltaTime);
        }
    }
}
