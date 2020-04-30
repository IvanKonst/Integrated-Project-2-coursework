using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeFloorSwitch : MonoBehaviour
{
    [SerializeField] GameObject switchOn;
    [SerializeField] GameObject switchOff;

    [SerializeField] GameObject door;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            gameObject.GetComponent<SpriteRenderer>().color = switchOn.GetComponent<SpriteRenderer>().color;

            door.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;

            door.SetActive(true);
    }
}
