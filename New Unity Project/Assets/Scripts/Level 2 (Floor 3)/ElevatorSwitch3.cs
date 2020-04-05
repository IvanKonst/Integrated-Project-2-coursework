using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSwitch3 : MonoBehaviour
{
    [SerializeField] GameObject fakeHazard;

    public bool isOn;

    public void Start()
    {
        isOn = false;
    }

    public void DoInteraction()
    {
        if (isOn == false)
        {
            fakeHazard.SetActive(true);

            isOn = true;

        }

        else if (isOn == true)
        {
            fakeHazard.SetActive(false);

            isOn = false;

        }
    }
}
