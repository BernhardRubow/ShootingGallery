using UnityEngine;
using System.Collections;

public class CanScript : MonoBehaviour {

    public static bool SoundEnabled = false;
	private GameManagerScript m_GameManagerScript;
	private bool m_Fallen = false;
    private AudioSource m_audio;

	// Use this for initialization
	void Start () {
		var gameManager = GameObject.FindGameObjectWithTag("GameManager");
		m_GameManagerScript = gameManager.GetComponent<GameManagerScript>();

        m_audio = this.GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
		if(!m_Fallen && this.transform.position.y < 0.9f) {
			m_Fallen = true;
			m_GameManagerScript.ReportFallenCan();
		}
	}

    void OnCollisionEnter() {
        if (!m_Fallen && !m_audio.isPlaying && CanScript.SoundEnabled)
            m_audio.Play();
    }


}
