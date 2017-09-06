using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards{

public class CardGenerator : MonoBehaviour {

		public List<Card> cards;
	// Use this for initialization
	void Start () {
			cards = new List<Card> ();
		QualitySettings.antiAliasing = 2;
		//card.AddComponent<Rigidbody>();
	
		for (int i = 0; i < 10; i++) {
			var card = new Card (new Vector3 (0f + (i*2f),-8, 10),"nyuszi");		
				cards.Add (card);
		//	card.transform.rotation = new Quaternion (0f, 0.1f * i, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i< cards.Count;i++){
				cards[i].rotate(new Vector3(0,40,0));
		}
	}
}
}