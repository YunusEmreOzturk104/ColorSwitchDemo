using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotationController : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed;
    

 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed);
    }
   
}
