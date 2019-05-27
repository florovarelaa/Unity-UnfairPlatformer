using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvTile : MonoBehaviour {

	[SerializeField]
	private int afterColVelX, afterColVelY;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,0);
	}
	
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Player"){

			other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(afterColVelX, afterColVelY);
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
		}
	}
}
