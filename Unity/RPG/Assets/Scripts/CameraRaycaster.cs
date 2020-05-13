using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycaster : MonoBehaviour {
public Layer[] LayerBilgileri ={
Layer.Canavar,
Layer.Zemin
};	

	// Use this for initialization
	
	float Backgroundmesafe = 100f;
	Camera myCamera;
	RaycastHit m_hit;
	public RaycastHit hit{
		get{return m_hit;}
	}
	
	Layer m_LayerHit;
	public Layer LayerHit{
		get{return m_LayerHit;}
	}





	
	
	void Start () {
		
		myCamera=Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
		foreach(Layer layer in LayerBilgileri){
			var hit=LayerDuzenleme(layer);
		if(hit.HasValue){
			m_hit=hit.Value;
			m_LayerHit=layer;
			return;
		}
		}
		m_hit.distance=Backgroundmesafe;
		m_LayerHit=Layer.RaycastEndStop;
		
	}

	RaycastHit? LayerDuzenleme(Layer layer){
		int layerMask =1 <<(int)layer;
		Ray raycast =myCamera.ScreenPointToRay(Input.mousePosition);

		RaycastHit hit;
		bool hasHit= Physics.Raycast(raycast,out hit,Backgroundmesafe,layerMask);

		if(hasHit){
			return hit;
		}
		return null;



	}








}
