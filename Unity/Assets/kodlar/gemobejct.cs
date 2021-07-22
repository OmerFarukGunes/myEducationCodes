 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemobejct : MonoBehaviour
{
    //arkaplanlar motor üzerinden alınacak şekilde public edildi.
    public GameObject gokyuzu;
    public GameObject gokyuzu1;
    //arkaplanların rigid body sine ulaşmak için fizikler tanımlandı.
    Rigidbody2D fizik;
    Rigidbody2D fizik1;
    //arkaplan geçiş hızının bir nevi karakter hızını belirlenecek değişken.
    public float arkaplanhiz;
    //arkaplanın tekrar tekrar yer değişmesi için uzunluğu bilinmesi gerek.
    float uzunluk = 0;
    //engellere ulaşmak ve kaç adet girileceğini motor üzerinden kaydetmek için gerekli olan değişkenler.
    public GameObject engel;
    public int kacadetengel;
    //engel sayısı kadar engeli hareket ettirmek için dizi oluşturuldu.
    GameObject[] engeller;
    float zaman = 0;
    int sayac = 0;
    void Start()
    {
        //fiziklere arkaplanların rigidbodyhsi verildi.
        fizik = gokyuzu.GetComponent<Rigidbody2D>();
        fizik1 = gokyuzu1.GetComponent<Rigidbody2D>();
        //bu fiziklere ivme verildi.
        fizik.velocity = new Vector2(0, arkaplanhiz);
        fizik1.velocity = new Vector2(0, arkaplanhiz);
        // gökyüzünün y eksenindeki uzunluğu alındı.
        uzunluk = gokyuzu.GetComponent<BoxCollider2D>().size.y;
        //kaç adet engel olacağı belirlendi.
       engeller = new GameObject[kacadetengel];
        for (int i = 0; i < engeller.Length; i++)
        {
      //adet sayısı kadar engel oluşturuldu.
            engeller[i] = Instantiate(engel, new Vector2(-20, -20), Quaternion.identity);
       //engellerin fizikengel adı altında rigidbodysi atandı.
            Rigidbody2D fizikengel = engeller[i].AddComponent<Rigidbody2D>();
           //yerçekimi 0 landı.
            fizikengel.gravityScale = 0;
            //engellere hız verildi.
            fizikengel.velocity = new Vector2(0, arkaplanhiz);
        }
       
    }
    void Update()
    {
       
        //gökyüzünün haritanın üst dışına çıkınca en alta geçmesi sağlandı ve döngü oluşturuldu.
       if (gokyuzu.transform.position.y >= 9.98f)
        {
            gokyuzu.transform.position = new Vector3(0, -9.98f);
        }
        if (gokyuzu1.transform.position.y >= 9.98f)
        {
            gokyuzu1.transform.position = new Vector3(0, -9.98f);
        } 
        //zamana bağlı olarak 1 ve 2.5 sn arasında engel oluşumu sağlandı.
       zaman += Time.deltaTime;
        float a = Random.Range(1f, 2.5f);
        if (zaman > a)
        {
            zaman = 0;
           //engellerin oluşacağı harita dışına çıkmayacağı rasgele aralık belirlendi
            float Xekseni = Random.Range(-1.75f, 1.75f);
            //engellerin pozisyonuna göre çıkarılması sağlandı.
            engeller[sayac].transform.position = new Vector3(Xekseni,-6.5f);
            sayac++;
            if (sayac >= engeller.Length)
            {
             //sayac sıfırlandı ve bu sayede engellerin sonsuz tane yapılması sağlandı. 
             //hikaye modunda bu if kalkacak ve sonsuz döngü değilde engel sayısı kadar engel oluşacaktır.
                sayac = 0;
            }
        }
       
    }
}
