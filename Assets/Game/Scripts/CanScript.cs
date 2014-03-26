using UnityEngine;
using System.Collections;

public class CanScript : MonoBehaviour {

	private GameManagerScript m_GameManagerScript;
	private bool m_Fallen = false;

	// Use this for initialization
	void Start () {
		var gameManager = GameObject.FindGameObjectWithTag("GameManager");
		m_GameManagerScript = gameManager.GetComponent<GameManagerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!m_Fallen && this.transform.position.y < 0.9f) {
			m_Fallen = true;
			m_GameManagerScript.ReportFallenCan();
		}
	}
}
