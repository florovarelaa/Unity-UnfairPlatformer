using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundHorizontalLength;

	// Use this for initialization
	void Start () {

		groundCollider = gameObject.GetComponent<BoxCollider2D>();
		groundHorizontalLength = groundCollider.size.x;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(PlayerController.Instance.transform.position.x > groundHorizontalLength){
			RepositionBagkgroundRight();
		}
		
	}

	private void RepositionBagkgroundRight(){

		Vector2 groundOffSet = new Vector2 (groundHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffSet;
	}

	private void RepositionBagkgroundLeft(){

		Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position - groundOffSet;
	}
}
