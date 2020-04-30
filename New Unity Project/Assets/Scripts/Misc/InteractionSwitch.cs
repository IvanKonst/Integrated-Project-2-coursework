using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSwitch : MonoBehaviour
{
    public GameObject door;

    public void DoInteraction()
    {
        door.SetActive(false);
    }
}
