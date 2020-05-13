using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    //bu kod build edilince sil. her seferinde baştan başlamanı sağlar bu start fonku.
    void Start()
    {
        PlayerPrefs.DeleteAll(); 
    }
    //sahneyi yükleyen koddur. bu kodu çalıştırmak için butonun onclick triggerının içerisine burayı seçiyoruz.     
    public void oyunagit()
    {
        //oyun ilk açıldığında kayıt dosyası olmicak 0 değeri dönecek o yüzden ilk açılış için if içerisini dönüyoruz.
        int kayitlilevel = PlayerPrefs.GetInt("kayit");
            if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel + 1);
        }
            //kalan bölümde devam edecek.
        else
        {
SceneManager.LoadScene(PlayerPrefs.GetInt("kayit"));
        }
        
    }
    public void cik()
    {
        //oyun çıktısını aldıktan sonra bu komut çalışır.
        Application.Quit();
    }
}
