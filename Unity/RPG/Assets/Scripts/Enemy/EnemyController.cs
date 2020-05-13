using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyController : MonoBehaviour {
	[SerializeField] float maxHp=100f;
	[SerializeField] float SaldiriMesafesi=4f;
	AICharacterControl ai =null;
	GameObject player =null;
	float currentHp=100f;

	public float hpYüzdesi{
		get{
			return currentHp/maxHp;
		}
	}

	// Use this for initialization
	void Start () {
		player =GameObject.FindGameObjectWithTag("Player");
		ai=GetComponent<AICharacterControl>();

		
	}
	
	// Update is called once per frame
	void Update () {
		float mesafe = Vector3.Distance(player.transform.position,transform.position);
		if(mesafe<SaldiriMesafesi){
			ai.SetTarget(player.transform);
		}else{
			ai.SetTarget(transform);
		}
		
	}
}
