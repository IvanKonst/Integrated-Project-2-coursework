using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailFloorSwitch : MonoBehaviour
{
    [SerializeField] GameObject switchOn;
    [SerializeField] GameObject switchOff;

    [SerializeField] GameObject door1, door2;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {

            gameObject.GetComponent<SpriteRenderer>().color = switchOn.GetComponent<SpriteRenderer>().color;

            door1.SetActive(false);
            door2.SetActive(false);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {

            gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;

            door1.SetActive(true);
            door2.SetActive(true);
        }
    }
}
