using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool isReachBorder = false;
    bool isReachMinBorder;
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector3 movement;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (transform.position.x >= 10)
        {
            isReachBorder = true;
        }
        else if (transform.position.x <= -7)
        {
            isReachBorder = false;
        }
    }
    void FixedUpdate()
    {
        if (isReachBorder)
        {
            moveCharacter(-movement);
        }
        else
        { 
            moveCharacter(movement);
        }
    }
    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }
}
