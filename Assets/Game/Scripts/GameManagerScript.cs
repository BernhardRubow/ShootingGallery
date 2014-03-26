using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {


    private int m_Score = 0;
    private int m_ScoreForFallenCan = 200;
    private int m_ScoreForRemainingBall = 1000;
	private int m_Cans = 18;
	private int m_FallenCans = 0;
	private GuiTextScript m_GuiText;



	// Use this for initialization
	void Start () {
		m_GuiText = this.GetComponent<GuiTextScript>();
		m_GuiText.SetCans(m_FallenCans,m_Cans - m_FallenCans);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Methode um dem Gamemanager zu melden, dass
    // eine Dose umgefallen ist
    public void ReportFallenCan() {
		m_FallenCans++;
		m_GuiText.SetCans(m_FallenCans,m_Cans - m_FallenCans);
    }
}
