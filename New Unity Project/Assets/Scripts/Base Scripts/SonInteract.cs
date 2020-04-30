using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonInteract : MonoBehaviour
{
    [SerializeField]
    GameObject currentInterObj = null;
    public GameManager gm;

    public bool nearPhase = false;

    void Update()
    {
        if (Input.GetButtonDown("InteractSon") && currentInterObj)
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

        if (collision.CompareTag("PhaseInteract"))
        {
            nearPhase = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("InteractableObject"))
        {
            if (collision.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }

        }

        if (collision.CompareTag("PhaseInteract"))
        {
            if (collision.gameObject == currentInterObj)
            {
                currentInterObj = null;
                nearPhase = false;
            }

        }
        
    }
}
