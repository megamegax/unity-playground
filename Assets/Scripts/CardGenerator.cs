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
			int row = 0;
			int maxColumn = 5;
			int column = 0;
		for (int i = 0; i < 25; i++) {
				var card = new Card (new Vector3 (-2.5f + (column*2f),(row*1.5f) + -8, 10),"nyuszi");		
				cards.Add (card);
				if (maxColumn == column) {
					column = 0;
					row++;
				} else {
					column++;
				}
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