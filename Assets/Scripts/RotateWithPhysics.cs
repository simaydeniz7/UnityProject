using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithPhysics : MonoBehaviour
{
    public bool X_AxisRotate;
    public bool Y_AxisRotate;
    public bool Z_AxisRotate;
    public float amount;
    private void FixedUpdate()
    {
        if (X_AxisRotate)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(-transform.up * amount);
        }
        if (Y_AxisRotate)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(-transform.right * amount);
        }
        if (Z_AxisRotate)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(-transform.forward * amount);
        }
    }
}
