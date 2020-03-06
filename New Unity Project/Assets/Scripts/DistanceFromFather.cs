using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFromFather : MonoBehaviour
{
    [SerializeField]
    private Transform father;
    public bool SonIsOnShoulder = false;
    public int keypressed=0;

    [SerializeField] public Transform shoulder;
    [SerializeField] public Transform newsonposition;
    public float distance;
    public bool phaseState = false;
    //public Vector3 fatherplusy = new Vector3(1f,0f,0f);

    void Update()
    {
       // Debug.Log(father.transform.localrotation.x);
        distance = (father.transform.position.x - transform.position.x);

        if(distance <= -10 || distance >= 10)
        {
            phaseState = true;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
        }

        else
        {
            phaseState = false;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
        if(distance <= 3 && distance >-3)
        {
            if(Input.GetKeyDown(KeyCode.X) && SonIsOnShoulder==false)
            {
                
                Debug.Log("asd");
                transform.position = shoulder.transform.position;
                // son.transform.position = father.transform.position.y;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
                SonIsOnShoulder = true;
            }
          if(Input.GetKeyDown(KeyCode.Y) && SonIsOnShoulder==true)
            {
                transform.position = newsonposition.transform.position;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
                SonIsOnShoulder = false;
            }
            if (Input.GetKeyDown(KeyCode.Q) && SonIsOnShoulder == true)
            {
                //Interact
            }
        }
    }
}
