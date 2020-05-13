using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllball : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    int sayac=0;
    public int coinsayisi;
    public Text sayactext;
    public Text oyunkazandin;
    public GameObject ana;
    public Text oyunukaybettin;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }
    //fixed update sabit zamanlı olarak çalışır. 
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
                                  //x,y,z y yukarı yönlü yukarı doğru hareket istemiyoruz.
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*hiz);

    }
    //küp prefabının ayarlarından is trigger yaptığında top tetikleyiciye çarptığı anda bu kod çalışacak.
    //stay temas olduğu sürece. enter temas ettiyse tek sefer. exit ise temas oldu ve çıktıktan sonra yazılır. hepsinin başı on trigger.
    void OnTriggerEnter(Collider other)
    {
        //eğer bu ifi yapmazsan tüm triggerlı nesneleri yok eder.
        // küplere coin etiketini prefabından veriyoruz. ve böylece tagleri coin oluyor ve sadece onlar yokoluyor.
        if (other.gameObject.tag == "coin")
        {
            // istersen yok et  Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            //yada küp haritada kalır ama pasive olur.
            sayac++;
            sayactext.text = "sayac = " + sayac;
            if(sayac== coinsayisi)
            {
                oyunkazandin.text = "Oyunu kazandin";
            }
          
        }
        if (other.gameObject.tag == "character")
        {
            Destroy(ana);
            oyunukaybettin.text = "Oyunu kaybettin";
        }


    }
}
