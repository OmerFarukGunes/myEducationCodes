using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamecontrol : MonoBehaviour
{
    public GameObject astreoid;
    public Vector3 randompos;
    public float baslangicbekleme;
    public float olusturmabekleme;
    public float dongubekleme;
    int score;
    public Text text;
    void Start()
    {
      
        score = 0;
        text.text = "score= " + score;
        StartCoroutine (olustur());
    }
    //ıe numerator farklı bir şekilde çalıştırılan zamanla tekrar dönen bir fonksiyondur.
    IEnumerator olustur()
    {
        //1 sn bekle.
        yield return new WaitForSeconds(baslangicbekleme);
        while (true)
        {
            //05. sn aralıklarla astroidleri oluştur.
    for(int i = 0; i < 20; i++)
        {
  //meteor haritanın en başından x te random olarak oluşacak.
        Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0, randompos.z);
        //Konum belirlendikten sonra hangi obje oluşacak onu belirliyoruz.
        Instantiate(astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmabekleme);
            }
    //for döngüsü bitince 1 saniye daha bekle ve while içerisinde geri dönüp oluşturmaya devam et
            yield return new WaitForSeconds(dongubekleme);
        }
    }
    //meteor yıkmada çalıştırıldı bu kod.
    public void scorearti(int gelenscore)
    {
        score += gelenscore;
    }
}
