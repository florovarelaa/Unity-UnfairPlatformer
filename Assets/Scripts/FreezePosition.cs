using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePosition : MonoBehaviour {

//Detiene objeto en caida
void OnTriggerEnter2D(Collider2D other){

	if(other.tag == "Player"){
		gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	}

}

}
