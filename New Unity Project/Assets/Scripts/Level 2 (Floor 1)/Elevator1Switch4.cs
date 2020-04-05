using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator1Switch4 : MonoBehaviour
{
    [SerializeField] GameObject memory;

    public bool isOn;

    public void Start()
    {
        isOn = false;
    }

    public void DoInteraction()
    {
        if (isOn == false)
        {
            memory.SetActive(true);

            isOn = true;

        }

        else if (isOn == true)
        {
            memory.SetActive(false);

            isOn = false;

        }
    }
}
