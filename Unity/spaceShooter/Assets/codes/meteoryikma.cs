using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoryikma : MonoBehaviour
{
    public GameObject bum;
    public GameObject playerbum;
    GameObject gamecontroll;
    //bir gamecontrol objesi oluşturuldu
    //bu gamecontrol koduna gitdip kontrol diye tanımlandı
    gamecontrol kontrol;
    //score arttırmak için burada her meteor yıkılmasında puan alsın.
     void Start()
    {
        //bu karaktere gitti
        gamecontroll = GameObject.FindGameObjectWithTag("gamecontrol");
        //kontrol karakter içerisindeki public değişkenlere ulaşımı sağlandı.
        kontrol = gamecontroll.GetComponent<gamecontrol>();
     
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag != "sinir")
        {
            //çarpan objeyi yok et.
        Destroy(col.gameObject);
            //kendini yok et
        Destroy(gameObject);
            //meteora patlama efekti. efekt,pozisyon,rotasyon sırasıyla.
        Instantiate(bum, transform.position, transform.rotation);
            //burada skor arttı
            kontrol.scorearti(10);
        }
     if(col.tag == "player")
        {
            //karaktere patlama efekti.
            Instantiate(playerbum, col.transform.position,col.transform.rotation);
        }
    }
}
