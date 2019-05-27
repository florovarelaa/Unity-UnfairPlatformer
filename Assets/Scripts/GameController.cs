using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public GameObject deathText;
	public GameObject winText;
	public float deaths;

	public bool isGameOver = false;
	public bool isGameWon = false;

	public Vector2 startPosition;
	public Vector2 LastCheckpointPos;

	// Use this for initialization
	void Awake () {
		if( Instance == null){
			Instance = this;
			DontDestroyOnLoad(Instance);
		} else if (Instance != this) {
			Destroy(gameObject);
		}
	}
	

	void Start() {
		startPosition = LastCheckpointPos;
		deaths = 0;
	}

	// Update is called once per frame
	void Update () {
			if(isGameOver && (Input.GetMouseButton(0) || Input.GetKeyDown("space"))){
				isGameOver = false;
				deathText.SetActive(false);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
			if(isGameWon && (Input.GetMouseButton(0) || Input.GetKeyDown("space"))){
				isGameWon = false;
				winText.SetActive(false);
				LastCheckpointPos = startPosition;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
	}

	public void Die(){
		deaths++;
		deathText.GetComponent<Text>().text = "DEATHS \n" + deaths;
		deathText.SetActive(true); 
		isGameOver = true;
	}

	public void Win(){
		deaths = 0;
		winText.GetComponent<Text>().text = "You won after " + GameController.Instance.deaths + " deaths \n Press SPACE or RIGHT CLICK to RESTART";
		winText.SetActive(true);
		isGameWon = true;
	}
}
