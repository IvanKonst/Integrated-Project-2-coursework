using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator2FloorSwitch1 : MonoBehaviour
{
    [SerializeField] GameObject switchOn;
    [SerializeField] GameObject switchOff;

    [SerializeField] Light spotLight1;
    [SerializeField] GameObject door;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {
            gameObject.GetComponent<SpriteRenderer>().color = switchOn.GetComponent<SpriteRenderer>().color;

            spotLight1.enabled = true;
            door.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {
            gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;

            spotLight1.enabled = false;
            door.SetActive(true);
        }
    }
}
