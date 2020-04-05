using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator2Switch2 : MonoBehaviour
{
    [SerializeField] GameObject fakeHazard1, fakeHazard2;

    public bool isOn;

    public void Start()
    {
        isOn = false;
    }

    public void DoInteraction()
    {
        if (isOn == false)
        {
            fakeHazard1.SetActive(true);
            fakeHazard2.SetActive(true);

            isOn = true;

        }

        else if (isOn == true)
        {
            fakeHazard1.SetActive(false);
            fakeHazard2.SetActive(false);

            isOn = false;

        }
    }
}
