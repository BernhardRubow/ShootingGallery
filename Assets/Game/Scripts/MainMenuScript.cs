using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {


        if (GUI.Button(new Rect(200, 50, 400, 100), "New Game"))
            Application.LoadLevel("MainGameScene");

        if (GUI.Button(new Rect(200, 190, 400, 100), "Credit"))
            Application.LoadLevel("CreditsScene");

        if (GUI.Button(new Rect(200, 330, 400, 100), "Exit"))
            Application.Quit();

    }
}
