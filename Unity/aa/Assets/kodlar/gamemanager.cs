using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamemanager : MonoBehaviour
{
    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    public Text donencemberlevel;
    public Text bir,iki,uc;
    public int kactopolsun;
    bool kontrol = true;
    
    void Start()
    {
        //hangi levelde kaldığını kaydeder.
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));
        donencember= GameObject.FindGameObjectWithTag("donencember");
        anacember = GameObject.FindGameObjectWithTag("anacember");
        //levelin ismi topun üzerinde yazacak.
        donencemberlevel.text = SceneManager.GetActiveScene().name;
        if (kactopolsun < 2)
        {
            //iki tırnak arası boşluk yapınca int değeri string değere dönüştürür.
            bir.text = kactopolsun + "";
        }
        else if (kactopolsun < 2)
        {
            bir.text = kactopolsun + "";
            iki.text = (kactopolsun-1) + "";
        }
        else
        {
            bir.text = kactopolsun + "";
            iki.text = (kactopolsun - 1) + "";
            uc.text = (kactopolsun - 2) + "";
        }
      
    }
     
    //bu anacember kodunun içerisinde çağırılacak.
    public void toplardatextgosterme()
    {
        //her bu komut çağırılınca ok sayısı azalacak.
        kactopolsun -= 1;
        if (kactopolsun < 2)
        {
          
            bir.text = kactopolsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kactopolsun < 2)
        {
            bir.text = kactopolsun + "";
            iki.text = (kactopolsun - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = kactopolsun + "";
            iki.text = (kactopolsun - 1) + "";
            uc.text = (kactopolsun - 2) + "";
        }
         if (kactopolsun == 0)
        {
            StartCoroutine(yenilevel());
        }

    }
    IEnumerator yenilevel()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        //kontrol olma sebebi son top hakkıyla beraber kullanıcı hala game over olabilir.
        if (kontrol)
        {        //her seferinde bu koıdu kullancaksak +1 yazıp o an hangi leveldeysek onun bir fazlasını alacaz. int parse olmasının sebebi
                 //ise level ismi 1 +1 yapınca 11 yazar bize. int değer olsunki 1+1=2 yapsın.
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(1.5F);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }

    }
    public void OyunBitti()
    {
        StartCoroutine(Metot());
    }
     IEnumerator Metot()
    {
        //oyun bitince iki kodda durmuş olacak.
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        //oyun bitince animasyonu çalıştıran tetikleyici çalıştırıyor.
        animator.SetTrigger("oyunbitti");
        kontrol = false;
        yield return new WaitForSeconds(1.5f);
        
                //bir saniye sonra menüye dönüyor.
        SceneManager.LoadScene("anamenu");
    }
}
