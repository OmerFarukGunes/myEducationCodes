 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAyarlari : MonoBehaviour {
	[SerializeField] Texture2D zeminCursor=null;
	[SerializeField] Texture2D zeminClickCursor=null;
	[SerializeField] Texture2D EnemyCursor=null;
	[SerializeField] Texture2D EnemyClickCursor=null;






	[SerializeField] Vector2 CursorBoyutu= new Vector2(96,96);
	CameraRaycaster cameraRaycaster;

	// Use this for initialization
	void Start () {
		cameraRaycaster = GetComponent<CameraRaycaster>();
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(cameraRaycaster.LayerHit){
			case Layer.Zemin:

			Cursor.SetCursor(zeminCursor,CursorBoyutu,CursorMode.Auto);
			if (Input.GetMouseButtonDown(0)){

			Cursor.SetCursor(zeminClickCursor,CursorBoyutu,CursorMode.Auto);

			}
			break;
			case Layer.Canavar:
			
			Cursor.SetCursor(EnemyCursor,CursorBoyutu,CursorMode.Auto);
			if (Input.GetMouseButtonDown(0)){

			Cursor.SetCursor(EnemyClickCursor,CursorBoyutu,CursorMode.Auto);

			}


			break;





			

		}






		
	}
}
