using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonMovement : MonoBehaviour
{
    public GameObject fathershoulderleft;
    public GameObject fathershoulderright;
    public DistanceFromFather distancefromfather;

    public float speed = 5f;
    public float jump = 5f;
    public bool isGrounded = false;



    void Update()
    {
        if(distancefromfather.SonIsOnShoulder==false)
        {
        Move();
        Jump();
        }
        else
        {
            if (distancefromfather.distance > 0)
            {
                transform.position = fathershoulderleft.transform.position;
            }
            else
            {
                transform.position = fathershoulderright.transform.position;
            }
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalSon"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("JumpSon") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }
        
    }
}
