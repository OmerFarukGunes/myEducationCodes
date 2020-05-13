using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gamecontrole : MonoBehaviour
{
    public GameObject gokyuzu;
    public GameObject gokyuzu1;
    Rigidbody2D fizik;
    Rigidbody2D fizik1;
    public float arkaplanhiz;
    float uzunluk = 0;
    public GameObject engel;
    public int kacadetengel;
    GameObject[] engeller;
    float zaman = 0;
    int sayac = 0;
    void Start()
    {
        //gökyüzünün ilerlemesi sağlanı.
        fizik = gokyuzu.GetComponent<Rigidbody2D>();
        fizik1 = gokyuzu1.GetComponent<Rigidbody2D>();
        fizik.velocity = new Vector2(-arkaplanhiz, 0);
        fizik1.velocity = new Vector2(-arkaplanhiz, 0);
        uzunluk = gokyuzu.GetComponent<BoxCollider2D>().size.x;
        engeller = new GameObject[kacadetengel];
        for(int i=0; i < engeller.Length; i++)
        {
            //obje oluşturm haritanın dışında 
            engeller[i] = Instantiate(engel,new Vector2(-20,-20),Quaternion.identity);
            //bu şekilde rigidbody ekleyebilirsin.
            Rigidbody2D fizikengel= engeller[i].AddComponent<Rigidbody2D>();
            //yerçekimim 0 olacak.
            fizikengel.gravityScale = 0;
            fizikengel.velocity = new Vector2(-arkaplanhiz, 0);
        }
    }
    void Update()
    {
        //gokyuzunun her daim dönmesini sağlar.
        if (gokyuzu.transform.position.x <=-uzunluk)
        {
            gokyuzu.transform.position += new Vector3((uzunluk * 2)-0.2f, 0);
        }
        if (gokyuzu1.transform.position.x <= -uzunluk)
        {
            gokyuzu1.transform.position += new Vector3((uzunluk * 2) - 0.2f, 0);
        }
        zaman += Time.deltaTime;
        float a = Random.Range(1.5f, 2.5f);
        if (zaman > a)
        {
          zaman = 0;
            // bu şekilde y ekseninde engeller yer değieşcek ve her sıfırlanışta farklı yerde olacak.
            float Yekseni = Random.Range(-0.70f,1.30f);
            engeller[sayac].transform.position = new Vector3(18.5f,Yekseni);
            sayac++;
            if(sayac >= engeller.Length)
            {
                sayac = 0;
            }
        }
    }
    public void oyunbitti()
    {
        for (int i = 0; i < engeller.Length; i++)
        {
            engeller[i].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            fizik.velocity = Vector2.zero;
            fizik1.velocity = Vector2.zero;
        }
    }
}
