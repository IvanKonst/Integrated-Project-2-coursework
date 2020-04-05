using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator1Switch2 : MonoBehaviour
{
    [SerializeField] GameObject door1;

    public bool isOn;

    public void Start()
    {
        isOn = false;
    }

    public void DoInteraction()
    {
        if (isOn == false)
        {
            door1.SetActive(true);

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(false);

            isOn = false;

        }
    }
}
