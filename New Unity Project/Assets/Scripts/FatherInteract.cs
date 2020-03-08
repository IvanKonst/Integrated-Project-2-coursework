using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FatherInteract : MonoBehaviour
{
    [SerializeField]
    GameObject currentInterObj = null;
    public int Shovel = 0;

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
        if (collision.CompareTag("Shovel"))
        {
            Debug.Log("ASd");
            Shovel++;

        }


        if (collision.CompareTag("Endofthelevel"))
        {
            if (Shovel == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("yes");
            }
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
