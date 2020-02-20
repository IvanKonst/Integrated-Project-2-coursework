using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherInteract : MonoBehaviour
{
    [SerializeField]
    GameObject currentInterObj = null;

    void Update()
    {
        if(Input.GetButtonDown("InteractFather") && currentInterObj)
        {
            currentInterObj.SendMessage("DoInteraction");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("InteractableObject"))
        {
            currentInterObj = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("InteractableObject"))
        {
            if(collision.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
        }
    }
}
