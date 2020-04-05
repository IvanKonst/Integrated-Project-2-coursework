using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator2Switch3 : MonoBehaviour
{
    [SerializeField] GameObject door1;
    [SerializeField] GameObject waterHazard;
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
            waterHazard.GetComponent<HazardManager>().isOn = true;

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(false);
            waterHazard.GetComponent<HazardManager>().isOn = false;

            isOn = false;

        }
    }
}
