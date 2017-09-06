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
			card.name = "Card x=" + position.x + "y=" +position.y + "z=" +position.z;
			Texture2D tex = Resources.Load(pictureName) as Texture2D;	
			card.GetComponent<Renderer>().material.mainTexture = tex;
			card.transform.position = position;
			card.transform.localScale = new Vector3 (2f, 1f, 0.01f);
			var angle = 10 * position.x * Math.Abs (position.x);
			if (angle == 360) {
				angle = 90;
			}
			if (angle == -360) {
				angle = -90;
			}
			if (angle == 160) {
				angle = 60;
			}
			if (angle == -160) {
				angle = -60;
			}
			UnityEngine.Debug.Log (card.name + " ->" + angle);
			card.transform.rotation = Quaternion.Euler(new Vector3(0,angle,0));

		}

		public void rotate(Vector3 rotationMatrix){
			//card.transform.Rotate (rotationMatrix * Time.deltaTime, Space.World);
		}
	}
}

