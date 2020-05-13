using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject character;
    Vector3 aradakimesafe;
    void Start()
    {
        aradakimesafe = transform.position - character.transform.position;
    }

    //kamera bu şekilde yapılınca titreme olamz.
    void LateUpdate()
    {
        transform.position = character.transform.position + aradakimesafe;
            
    }
}
