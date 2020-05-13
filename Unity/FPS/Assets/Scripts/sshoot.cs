using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sshoot : MonoBehaviour
{
    public Camera camera;
    public int range;
    [Header("Gun Damage On Hit")]
    public int damage;
    public GameObject bloodPrefab;
    public GameObject decal; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position,camera.transform.forward,out hit,10)) //bir ışın gönderiyoruz cameradan cameranın önüne doğru ve 10 metre menzil ile. bu menzili her siah için her daim ayarla
        {
            if(hit.transform.tag == "zombie") //eğer ışın zombie tagına çarparsa
            {
                hit.transform.GetComponent<ZombieHealth>().Hit(damage); //zombienin içindeki scripte git ve hit fonkunu çağır.
                generateBloodEffect(hit);
            }    //ışın göndermek için hedefin kesinlikle collidera sahip olması gerekir.
            else
            {
                generateHitEffect(hit);
            }
        }
    }

    private void generateBloodEffect(RaycastHit hit)
    {
        GameObject bloodObject = Instantiate(bloodPrefab, hit.point, hit.transform.rotation); //Objemiz prejab olduğundan onu instantiate etmen lazım.
  /* bloodPrefab.transform.position = hit.point; //ateşin çarpıtığı noktaya kan efektini transform et
   bloodPrefab.SetActive(true); //ve orad aktif et. *///obje prefab olmasaydı bu şekilde yapabilirdin.
    }

    private void generateHitEffect(RaycastHit hit)
    {//mermi izi oluşturulacak.
        GameObject hitObject = Instantiate(decal, hit.point, Quaternion.identity); //tam vurduğumuz yerde izin oluşması lazım. ondan dolayı quanternion ile yaptık.
        hitObject.transform.rotation = Quaternion.FromToRotation(decal.transform.forward*-1, hit.normal); //oluşacak deliği zemine göre tam oturmasını sağlıyoruz.
        //kendi rotasyonunu vurulan yerin N sine göre ayarla.  
        /*       N   /   
         *   x -- \/   x zemine doğru sıkıyor zeminin n si alınıp rotasyon ayarlanıyor.
         *   *    / */
    }
}
