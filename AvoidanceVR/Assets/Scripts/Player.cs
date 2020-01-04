using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maximunSpeed = 5.5f;
    public float acceleration = 1f;
    public float jumpingForce = 500f;
    public float jumpingCooldown = 1.5f;

    public bool reachedFinishline = false;

    private float jumpingTimer = 0f;
    private float speed;

    void Start()
    {
        
    }
    
    void Update()
    {
       jumpingTimer -= Time.deltaTime;

       // Moves player forward
       speed += acceleration * Time.deltaTime;

       if (speed > maximunSpeed)
       {
            speed = maximunSpeed;
       }

       transform.position += speed * Vector3.forward * Time.deltaTime;

        // Prevents player from constantly jumping in midair
        if(GvrViewer.Instance.Triggered || Input.GetKeyDown("space")) 
        {
            if (jumpingTimer <= 0f)
            {
                jumpingTimer = jumpingCooldown;
                this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpingForce);
            }
        }
    }

    void OnTriggerEnter(Collider collider) 
    {
        //Debug.Log(collider.tag);     
        if (collider.tag == "Obstacle")
        {
            speed *= 0.3f;
        }

        if (collider.tag == "Finiah Line")
        {
            reachedFinishline = true;
        }
    }
}
