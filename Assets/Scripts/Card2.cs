using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
	public class Card2: MonoBehaviour {
		public GameObject card;
		private bool rotate = false;
		void Start () {
			CardboardMagnetSensor.SetEnabled (true);
		}
		void Update(){
			if(CardboardMagnetSensor.CheckIfWasClicked() || GvrControllerInput.IsTouching || Input.anyKeyDown){
			//if (isCameraWatching()) {
				//rotate = true;
				card.transform.Rotate (new Vector3(0,40,0) * Time.deltaTime, Space.World);
			}
		
			if (rotate) {
				//card.transform.Rotate (new Vector3(0,40,0) * Time.deltaTime, Space.World);
			}
		}
		private bool isCameraWatching(){
			RaycastHit hit;
			GameObject hittedObject = null;
			Camera camera = Camera.current;
			Vector3 cameraCenter = camera.ScreenToWorldPoint (new Vector3(Screen.width / 2, Screen.height / 2, camera.nearClipPlane));
			Debug.DrawLine (cameraCenter, transform.forward);
			if (Physics.Raycast (cameraCenter, transform.forward,out hit,100)) {
				hittedObject = hit.transform.gameObject;
			}
			return hit.point.Equals(card.transform.position);
		}
	}
}