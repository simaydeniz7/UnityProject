using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool isHorizontal;
    public bool isVertical;
    public float rotateSpeed;
    void Update()
    {
        if (isHorizontal)
        {
            transform.Rotate(-rotateSpeed, -rotateSpeed, 0);
        }
        if (isVertical)
        {
            transform.Rotate(-rotateSpeed, 0, 0);
        }
    }
}
