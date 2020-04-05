using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSwitch4 : MonoBehaviour
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
            door1.SetActive(false);

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(true);

            isOn = false;

        }
    }
}
