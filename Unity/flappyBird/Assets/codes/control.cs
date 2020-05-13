using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour
{
    //kuşun ileri geri gidişi için animasyon lazım ki buda 3 fotoğrafı hızlıca kaydırarak elde edilecek.
    public Sprite[] kusSprite;
    SpriteRenderer SpriteRenderer;
    bool ilerigerikontrol = true;
    int kussayac = 0;
    float animasyonhizi = 0;
    Rigidbody2D fizik;
    int puan;
    public Text PuanText;
    bool gameover=true ;
    gamecontrole OyunKontrol;
    void Start()
    {
        //spriterenderer değişecek yani texture kaplaması bu yüzden ona ulaşılıyor.
        SpriteRenderer = GetComponent<SpriteRenderer>();
        fizik = GetComponent<Rigidbody2D>();
        OyunKontrol = GameObject.FindGameObjectWithTag("GameController").GetComponent<gamecontrole>();
    }
     void Update()
    {

        if (Input.GetMouseButtonDown(0)&& gameover == true)
        {
            //her seferinde yerçekimini 0 lıyoruz ki karşı etki büyümesin.
            fizik.velocity = new Vector2(0,0);
            fizik.AddForce(new Vector2(0,200));
        }
        //kafa hareketi kodlaması.
        if (fizik.velocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 45);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -45);
        }
        Animasyon();    
    }
    void Animasyon()
    {
        animasyonhizi += Time.deltaTime;//her defasında 0-0.1-0.2 diye gidip olacak.
        if (animasyonhizi > 0.1f)
        {
            animasyonhizi = 0;
        if (ilerigerikontrol)
        {
            SpriteRenderer.sprite = kusSprite[kussayac];
            kussayac++;
            //elimizde 3 fotoğraf var 3 e kadar saydıktan sonra kontrol false olsun ve iften çıksın.
            if (kussayac == kusSprite.Length)
            {
                kussayac--;
                ilerigerikontrol = false;
            }
        }
        else
        {
            kussayac--;
            SpriteRenderer.sprite = kusSprite[kussayac];
            if (kussayac == 0)
            {
                kussayac++;
                //bundan sonra yine kırpmaya devam edecek.
                ilerigerikontrol = true;
          }
        }
      }
   }
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "puan")
        {
            puan++;
            PuanText.text = "Puan = " + puan;
        }
        if(col.gameObject.tag == "engel")
        {
            gameover = false;
            OyunKontrol.oyunbitti();
        }
    }
}
