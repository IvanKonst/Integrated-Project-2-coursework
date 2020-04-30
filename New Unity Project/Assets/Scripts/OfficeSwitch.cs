using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeSwitch : MonoBehaviour
{
    [SerializeField] GameObject door1, door2;
    [SerializeField] Light spotLight1;
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
            spotLight1.enabled = true;

            isOn = true;

        }

        else if (isOn == true)
        {
            door1.SetActive(true);
            door2.SetActive(false);
            spotLight1.enabled = false;

            isOn = false;

        }
    }
}
