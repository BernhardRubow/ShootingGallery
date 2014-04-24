using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameManagerScript.TotalNumberCans != 0)
            GameManagerScript.TotalNumberCans = 0;

	}

    void OnGUI() {


        if (GUI.Button(new Rect(200, 53, 400, 53), "New Game"))
            Application.LoadLevel("MainGameScene");

        if (GUI.Button(new Rect(200, 159, 400, 53), "Intro"))
            Application.LoadLevel("IntroScene");

        if (GUI.Button(new Rect(200, 265, 400, 53), "Credits"))
            Application.LoadLevel("CreditsScene");

        if (GUI.Button(new Rect(200, 371, 400, 53), "Exit"))
            Application.Quit();

        

    }
}
