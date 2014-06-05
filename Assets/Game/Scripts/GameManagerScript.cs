using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    // private field for the score
    private int m_Score = 0;
    
    // the number of cans in a game
	private int m_Cans = 18;

    // the number of fallen cans in
    // the current game
	private int m_FallenCans = 0;

    // a field for the script that
    // controls the gui
	private GuiTextScript m_GuiText;

    // counter of all cans fallen during
    // a game
    public static int TotalNumberCans = 0;

    // last x-position of the camera. saved
    // to restore position of the camera
    // to the last player position when
    // level is reloaded
    public static float LastCameraXPosition = 3;

    // simple (very simple) statemachine
    public static string GameState;


	// Use this for initialization
	void Start () {

        // set the current game state
        GameState = "Started";

        // grab the attached guiscript component
		m_GuiText = this.GetComponent<GuiTextScript>();

        // Set some values on the guiscript component
		m_GuiText.SetCans(m_FallenCans,m_Cans - m_FallenCans);

        // restore last cameraposition, if there
        // is one saved.
        Camera.main.transform.position = new Vector3(
            GameManagerScript.LastCameraXPosition,
            Camera.main.transform.position.y,
            Camera.main.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

        // End condition for current game
        if (GameState == "End") {
            
            // reset gamestate
            GameState = "";

            // Start the ending
            StartCoroutine("MyMethod");
        }

	}

    // Method that ends the current game
    IEnumerator MyMethod() {
        
        // Wait 5 Seconds
        yield return new WaitForSeconds(5);

        // Ensure that no sound is played, when
        // the new cans are build up
        CanScript.SoundEnabled = false;

        // If the player knocked down all 18
        // cans take him to the next level.
        if (m_FallenCans == 18) {
            //save camera position.
            GameManagerScript.LastCameraXPosition = Camera.main.transform.position.x;
            
            // load next level
            Application.LoadLevel("MainGameScene");
        } else {
            // turn off the music
            var musicManager = GameObject.FindGameObjectsWithTag("MusicManager");
            GameMusicScript.IsPlaying = false;
            for (int i = 0, n = musicManager.Length; i < n; i++ )
                DestroyImmediate(musicManager[i]);
            // Load the menu
            Application.LoadLevel("MenuScene");
        }
    }

    // with this method, other scripts
    // can notify the gamemanager that
    // a cans is knocked down
    public void ReportFallenCan() {
		m_FallenCans++;
        GameManagerScript.TotalNumberCans++;
		m_GuiText.SetCans(m_FallenCans,m_Cans - m_FallenCans);
    }
}
