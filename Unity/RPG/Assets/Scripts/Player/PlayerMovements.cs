using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
[RequireComponent(typeof(ThirdPersonCharacter))]
public class PlayerMovements : MonoBehaviour {
	ThirdPersonCharacter m_Character;
	CameraRaycaster cameraRaycaster;
	Vector3 currentClickTarget;


	// Use this for initialization
	void Start () {
		cameraRaycaster=Camera.main.GetComponent<CameraRaycaster>();
		m_Character=GetComponent<ThirdPersonCharacter>();
		currentClickTarget=transform.position;


		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetMouseButton(0)){
			print("Tıklanan Obje"+ cameraRaycaster.hit.collider.gameObject.name.ToString());
			currentClickTarget=cameraRaycaster.hit.point;
		
		}
		m_Character.Move(currentClickTarget-transform.position,false,false);
		
	}
}
