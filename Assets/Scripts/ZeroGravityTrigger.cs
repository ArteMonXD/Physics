using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravityTrigger : MonoBehaviour
{
    public Vector3 pointUp;
    public Vector3 pointDown;
    public float speedMove;
    private Vector3 currentPoint;
    private bool down;
    private void Start()
    {
        currentPoint = pointDown;
        down = true;
    }
    void Update()
    {
        Move();
        PointSwitch();
    }
    private void PointSwitch()
    {
        if(transform.position == currentPoint)
        {
            if (down)
            {
                down = !down;
                currentPoint = pointUp;
            }
            else
            {
                down = !down;
                currentPoint = pointDown;
            }
        }
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentPoint, speedMove * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            other.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            other.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
