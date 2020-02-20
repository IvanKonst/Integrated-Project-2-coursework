using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFromFather : MonoBehaviour
{
    [SerializeField]
    private Transform father;

    private float distance;
    public bool phaseState = false;

    void Update()
    {
        distance = (father.transform.position.x - transform.position.x);

        if(distance <= -10 || distance >= 10)
        {
            phaseState = true;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
        }

        else
        {
            phaseState = false;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
    }
}
