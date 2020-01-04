using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float movementAmplitude = 0.1f;
    public float movementFrequency = 2f;

    void Start()
    {
        
    }

    
    void Update()
    {
        // We use local position becase the player camera must remain independent of the parent root
        transform.localPosition = new Vector3
        (
            transform.localPosition.x,                                               // x
            Mathf.Cos(transform.position.z * movementFrequency) * movementAmplitude, // y: Based off the world position of z in a cosine fashion 
            transform.localPosition.z                                                // z
        );

    }
}
