using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseObject : MonoBehaviour
{
    public GameObject son;

    void Update()
    {
        if (son.GetComponent<DistanceFromFather>().phaseState == true && son.GetComponent<SonInteract>().nearPhase == true)
        {
            GetComponent<Collider2D>().enabled = false;
        }

        else if (son.GetComponent<DistanceFromFather>().phaseState == false || son.GetComponent<SonInteract>().nearPhase == false)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
