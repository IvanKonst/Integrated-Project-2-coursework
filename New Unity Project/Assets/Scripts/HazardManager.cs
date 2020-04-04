using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardManager : MonoBehaviour
{
    public bool isOn;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Color colorOff = Color.blue;
    [SerializeField] Color colorOn = Color.red;
    private Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn == false)
        {
            rend.material.color = colorOff;
        }
        else if (isOn == true)
        {
            rend.material.color = colorOn;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Son") || collision.transform.CompareTag("Father"))
        {
            if(isOn == true)
            {
                collision.transform.position = spawnPoint.position;

            }
        }
    }
}
