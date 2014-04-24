using UnityEngine;
using System.Collections;

public class Introscript : MonoBehaviour {


    public Texture2D[] IntroScreens;
    public float Duration;

    private float time = 0;
    private int i = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time > Duration ) {
            time = 0;
            if (i < IntroScreens.Length - 1) {
                i++;
            }
            else{
                Application.LoadLevel("MenuScene");
            }
        }
	}

    void OnGUI() {

        GUI.DrawTexture(new Rect(0, 0, 800, 480), IntroScreens[i]);

    }
}
