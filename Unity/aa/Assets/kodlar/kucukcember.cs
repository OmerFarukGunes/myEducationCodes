using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = true;
    GameObject oyunyoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunyoneticisi = GameObject.FindGameObjectWithTag("gamemanager");
    }
    void FixedUpdate()
    {
        if (hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencember")
        {
            hareketkontrol = false;
            //bu kod dönen çemberle beraber dönmesini sağlar okun.
            transform.SetParent(col.transform);
        }
        //oklar birbirine temas ediyormu.
        if (col.tag == "kucukcember")
        {
            oyunyoneticisi.GetComponent<gamemanager>().OyunBitti();
        }
    }
}
