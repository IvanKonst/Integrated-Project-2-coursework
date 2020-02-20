using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSwitch : MonoBehaviour
{
    [SerializeField] GameObject switchOn;
    [SerializeField] GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = switchOff.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Father")
        {
            gameObject.GetComponent<SpriteRenderer>().color = switchOn.GetComponent<SpriteRenderer>().color;

            isOn = true;
        }
    }
}
