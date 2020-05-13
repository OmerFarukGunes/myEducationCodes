using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorrotasyon : MonoBehaviour
{
    Rigidbody fizik;
    public float speed;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
          // bu şekilde meteorun dönmesini sağlarsın.
        fizik.angularVelocity = Random.insideUnitSphere;
    }

}
