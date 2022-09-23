using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotZ;
    public float RotationSpeed;
    public float sizeRotation;
    public bool ClockwiseRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotZ > sizeRotation)
        {
            ClockwiseRotation = true;
        }
        if(rotZ < -sizeRotation)
        {
            ClockwiseRotation = false;
        }
        if (ClockwiseRotation == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
