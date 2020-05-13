using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	CameraRaycaster cRaycaster;
	// Use this for initialization
	void Start () {
		cRaycaster=GetComponent<CameraRaycaster>();
		
	}
	
	// Update is called once per frame
	void Update () {
		print(cRaycaster.LayerHit);
	}
}
