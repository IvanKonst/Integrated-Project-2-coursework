using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject doorForPhase;
    [SerializeField] GameObject son;
    
    void Update()
    {
        /*if(Switch.GetComponent<FloorSwitch>().isOn == true)
        {
            doorForSwitch.SetActive(false);
        }*/

        if(son.GetComponent<DistanceFromFather>().phaseState == true && son.GetComponent<SonInteract>().nearPhase == true)
        {
            doorForPhase.GetComponent<Collider2D>().enabled = false;
        }

        else if(son.GetComponent<DistanceFromFather>().phaseState == false || son.GetComponent<SonInteract>().nearPhase == false)
        {
            doorForPhase.GetComponent<Collider2D>().enabled = true;
        }
    }
}
