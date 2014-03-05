using UnityEngine;
using System.Collections;

public class planescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-Vector3.forward * 200 * Time.deltaTime);
		if (transform.position.y < -5500)
						Application.LoadLevel("MenuScene");
	}
}
