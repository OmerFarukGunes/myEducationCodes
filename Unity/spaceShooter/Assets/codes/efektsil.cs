using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektsil : MonoBehaviour
{ //bu patlamada oluşan efekti silerki fps düşmesin. bunu meteor ve player explosion efektine atıyoruz.
    void Start()
    {
        Destroy(gameObject,3);
    }

}
