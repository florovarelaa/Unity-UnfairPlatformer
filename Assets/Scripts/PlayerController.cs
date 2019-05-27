using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public static PlayerController Instance;

	[SerializeField]
	private float moveSpeed = 5f;
	public float jumpHeight;
	public bool isGrounded;
	public bool isDead = false;


	// Use this for initialization
	void Awake () {
		if( Instance == null){
			Instance = this;
		} else if (Instance != this) {
			Destroy(gameObject);
		}
	}

	void Start() {
		transform.position = GameController.Instance.LastCheckpointPos;
	}
	
	// Update is called once per frame
	void Update () {

		if(isDead){ return; }

			if(Input.GetAxisRaw("Horizontal") >= 1f || Input.GetAxisRaw("Horizontal") <= 1f){
				transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f ));
			}

			if(Input.GetKeyDown("up") && isGrounded){
				//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * jumpHeight * Time.deltaTime, 0f));
				gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 4.8f, 0f) * jumpHeight, ForceMode2D.Impulse);
				isGrounded = false;
			}

			if(gameObject.GetComponent<Rigidbody2D>().velocity.y == 0){
				isGrounded = true;
			}
		
	}

	public void Die(){
		gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		isDead = true;
		GameController.Instance.Die();
	}

}
