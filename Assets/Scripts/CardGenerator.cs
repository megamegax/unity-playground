using System;
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
			int maxColumn = 3;
			int column = -3;
		for (int i = 0; i < 28; i++) {
				var card = new Card (new Vector3 ((column*2f),-2 + (row*1.1f), 3 + -Math.Abs(column)),"nyuszi");		
				cards.Add (card);
				if (maxColumn == column) {
					column = -3;
					row++;
				} else {
					column++;
				}
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