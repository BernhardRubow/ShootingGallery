using UnityEngine;
using System.Collections;

public class GameMusicScript : MonoBehaviour {

    // Static field thats indicated,
    // if the audiosource is currently
    // playing a clip
    public static bool IsPlaying = false;

	// Use this for initialization
	void Start () {

        // grab the attached audiosource
        var audiosource = this.GetComponent<AudioSource>();

        // if the gameobject is marked as 
        // "not playing clip" the start 
        // the clip and mark the gameobject
        // as playing
        if (!GameMusicScript.IsPlaying) {
            GameMusicScript.IsPlaying = true;
            audiosource.Play();
        }
	}

    void Awake() {
        
        // mark this gameobject as
        // indestrucable on LevelLoad
        DontDestroyOnLoad(this.gameObject);
    }

	
}
