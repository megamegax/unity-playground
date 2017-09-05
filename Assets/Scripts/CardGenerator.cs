using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour {

	public GameObject card;

	// Use this for initialization
	void Start () {
		
		//card.AddComponent<Rigidbody>();
		card.AddComponent<MeshFilter>();
		card.AddComponent<BoxCollider>();
		card.AddComponent<MeshRenderer>();	

		for (int i = 0; i < 5; i++) {
			card.transform.position = new Vector3 (2.8f + i,0, 7.24f);		
		//	card.transform.rotation = new Quaternion (0f, 0.1f * i, 0f);
			Instantiate (card);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
