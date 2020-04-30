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
    public bool isGrounded;
    private Animator anim;
    private bool facingRight = true;
    private Quaternion localScale;

    private void Start()
    {
        isGrounded = true;
        anim = GetComponent<Animator>();
        localScale = transform.localRotation;
    }

    void Update()
    {
        if(distancefromfather.SonIsOnShoulder==false)
        {
            Move();
            Jump();
            
        }
        else
        {
            transform.position = fathershoulderleft.transform.position;
            
        }

       
    }

    private void LateUpdate()
    {
        if (Input.GetAxis("HorizontalSon") < 0)
        {
            localScale.y = 0;
        }

        if (Input.GetAxis("HorizontalSon") > 0)
        {
            localScale.y = 180;
        }

        transform.localRotation = localScale;
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

        if (isGrounded == false)
        {
            anim.SetBool("isJumping", true);
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }


    }
}
