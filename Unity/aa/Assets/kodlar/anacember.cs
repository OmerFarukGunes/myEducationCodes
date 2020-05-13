using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour
{
    GameObject oyunyoneticisi;
    public GameObject kucukcember;
    void Start()
    {
        oyunyoneticisi = GameObject.FindGameObjectWithTag("gamemanager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            cemberolustur();
        }
    }
    void cemberolustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
        oyunyoneticisi.GetComponent<gamemanager>().toplardatextgosterme();
    }
}
