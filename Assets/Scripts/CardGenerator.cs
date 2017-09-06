using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour {

	public List<GameObject> cards;
	// Use this for initialization
	void Start () {
		QualitySettings.antiAliasing = 2;
		//card.AddComponent<Rigidbody>();
	
		for (int i = 0; i < 5; i++) {
			var card = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cards.Add (card);
			card.name="Card "+i;					
			card.transform.position = new Vector3 (0f + (i*2f),-8, 10);	
			card.transform.localScale = new Vector3 (1.5f, 1f, 0.01f);

		//	card.transform.rotation = new Quaternion (0f, 0.1f * i, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i< cards.Count;i++){
			cards[i].transform.Rotate(new Vector3(0,10,0) * Time.deltaTime, Space.World);
		}
	}
}
