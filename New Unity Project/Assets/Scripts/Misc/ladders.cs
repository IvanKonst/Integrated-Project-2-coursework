using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladders : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag== "Son" && Input.GetKey(KeyCode.Space))
        {
            
            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if(other.tag == "Son" && Input.GetKey(KeyCode.S))
        {

            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, -speed);

        }
        else
        {
            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
        if (other.tag == "Father" && Input.GetKey(KeyCode.UpArrow))
        {
            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, speed);

        }
        else if (other.tag == "Father" && Input.GetKey(KeyCode.DownArrow))
        {

            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, -speed);

        }
        else
        {
            other.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
    }
}
