using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinir : MonoBehaviour
{
    //kurşun bu colliderın dışına çıktığında yok olsunki oyunda fps düşmesi olmasın.
     void OnTriggerExit(Collider col)
    {
        Destroy (col.gameObject);
    }
}
