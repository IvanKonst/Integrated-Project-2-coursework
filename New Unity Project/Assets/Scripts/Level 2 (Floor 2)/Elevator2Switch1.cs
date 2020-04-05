using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator2Switch1 : MonoBehaviour
{
    [SerializeField] GameObject door1, door2, door3;
    public bool isOn;

    public void Start()
    {
        isOn = true;
    }

    public void DoInteraction()
    {
        if (isOn == false)
        {
            door1.SetActive(false);
            door2.SetActive(true);
            door3.SetActive(false);

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(true);
            door2.SetActive(false);
            door3.SetActive(true);

            isOn = false;

        }
    }
}
