using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSwitch2 : MonoBehaviour
{
    [SerializeField] GameObject door1, door2, door3;
    [SerializeField] GameObject waterHazard;
    public bool isOn;

    public void Start()
    {
        isOn = false;
    }

    public void DoInteraction()
    {
        if(isOn == false)
        {
            door1.SetActive(false);
            door2.SetActive(true);
            door3.SetActive(false);
            waterHazard.GetComponent<HazardManager>().isOn = true;

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(true);
            door2.SetActive(false);
            door3.SetActive(true);
            waterHazard.GetComponent<HazardManager>().isOn = false;

            isOn = false;
            
        }
    }
}
