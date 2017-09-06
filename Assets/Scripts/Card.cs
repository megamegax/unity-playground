using System;
using UnityEngine;

namespace Cards
{
	public class Card
	{
		private GameObject card;
		public Card (Vector3 position, String pictureName)
		{ 
			card = GameObject.CreatePrimitive (PrimitiveType.Cube);
			card.name = "Card" + position.x+position.y+position.z;
			Texture2D tex = Resources.Load(pictureName) as Texture2D;	
			card.GetComponent<Renderer>().material.mainTexture = tex;
			card.transform.position = position;
			card.transform.localScale = new Vector3 (1.5f, 1f, 0.01f);

		}

		public void rotate(Vector3 rotationMatrix){
			card.transform.Rotate (rotationMatrix * Time.deltaTime, Space.World);
		}
	}
}

