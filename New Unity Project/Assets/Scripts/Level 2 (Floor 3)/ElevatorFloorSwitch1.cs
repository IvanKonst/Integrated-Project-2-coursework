using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorFloorSwitch1 : MonoBehaviour
{
    [SerializeField] GameObject switchOn;
    [SerializeField] GameObject switchOff;

    [SerializeField] Light spotLight;
    [SerializeField] GameObject waterHazard;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {
            gameObject.GetComponent<SpriteRenderer>().color = switchOn.GetComponent<SpriteRenderer>().color;

            spotLight.enabled = true;
            waterHazard.GetComponent<HazardManager>().isOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {
            gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;

            spotLight.enabled = false;
            waterHazard.GetComponent<HazardManager>().isOn = false;
        }
    }
}
