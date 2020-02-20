using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;

    public void OpenDoor()
    {
        door.SetActive(false);
    }
}
