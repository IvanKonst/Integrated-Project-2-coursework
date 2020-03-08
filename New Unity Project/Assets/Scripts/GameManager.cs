using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*[SerializeField]
    GameObject[] switches;

    [SerializeField]
    GameObject door;

    int noOfSwitches = 0;

    void Start()
    {
        GetNoOfSwitches();
    }

    private int GetNoOfSwitches()
    {
        int x = 0;

        for(int i =0; i<switches.Length; i++)
        {
            if (switches[i].GetComponent<FloorSwitch>().isOn == false)
                x++;
            else if (switches[i].GetComponent<FloorSwitch>().isOn == true)
                noOfSwitches--;

        }

        noOfSwitches = x;

        return noOfSwitches;
    }

    public void GetDoorState()
    {
        if(noOfSwitches <= 0)
        {
            door.SetActive(false);
        }
    }

    private void Update()
    {
        GetDoorState();
    }
    */

    [SerializeField] GameObject doorForSwitch;
    [SerializeField] GameObject doorForPhase;
    [SerializeField] GameObject Switch;
    [SerializeField] GameObject son;
    
    void Update()
    {
       // if(Switch.GetComponent<FloorSwitch>().isOn == true)
      //  {
      //      doorForSwitch.SetActive(false);
      //  }

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
