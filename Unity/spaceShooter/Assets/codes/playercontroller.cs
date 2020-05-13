using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    Vector3 vec;
    float vertical = 0;
    public float characterspeed;
    public float minX;
    public float maxX;
        public float minZ;
        public float maxZ;
    public float aim;
    float ateslemehizi = 0;
    public float atesgecensure;
    public GameObject bullet;
    public Transform  tetiknoktasi;
    AudioSource audio;
     void Start()
    {
        //karakterin fiziğini almak.
        fizik = GetComponent<Rigidbody>();
        //ateş etme sesi sadece ateş edince çalacak. 
        audio = GetComponent<AudioSource>();
    }
    //silah ateşlenmesi 
     void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time > ateslemehizi)
        {
            //atesleme hızını ayarlamak için oyun içerisindeki zamana unityde belirlene zamanı ekleyerek istenen saniyede bir atış yapabilmesini sağlar.
            //bu şekilde durmadan ardan ateş etmeyi engellersin.
            ateslemehizi = Time.time + atesgecensure;
            Instantiate(bullet, tetiknoktasi.position, Quaternion.identity);
            //her ateşte bu şekilde oynar.
            audio.Play();
        }
    }
    //karakter hareketi
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0, vertical);
        fizik.velocity = vec*characterspeed;
        //burada karakterin sınırları dışına çıkmamasını sağlıyoruz.
        //max ve min değerler unity üzerinden haritaya göre veriliyor.
        fizik.position = new Vector3
            (
            Mathf.Clamp(fizik.position.x, minX, maxX),
            0.0f,
              Mathf.Clamp(fizik.position.z, minZ, maxZ)
              );
        //sağa sola giderken karakter yamulsun.
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-aim);
    }
}
