using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	void LateUpdate(){

		transform.position = new Vector4(PlayerController.Instance.transform.position.x, this.transform.position.y, -10f);

	}
}
