using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {


    private int m_Score = 0;
    private int m_ScoreForFallenCan = 200;
    private int m_ScoreForRemainingBall = 1000;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Methode um dem Gamemanager zu melden, dass
    // eine Dose umgefallen ist
    public void ReportFallenCan() {

    }
}
