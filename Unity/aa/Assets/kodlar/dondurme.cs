using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme : MonoBehaviour
{
    public float hiz;
    void Update()
    {
        //topun sağa veya solu doğru dönüş kodu.
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
