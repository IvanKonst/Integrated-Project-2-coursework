using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryHandler : MonoBehaviour
{
    [SerializeField] private Image memory;

    public void DoInteraction()
    {
        memory.enabled = true;

        
    }

    private void Update()
    {
        if(memory.enabled == true && Input.GetButtonDown("Cancel"))
        {
            memory.enabled = false;

            Destroy(gameObject);
        }
    }
}
