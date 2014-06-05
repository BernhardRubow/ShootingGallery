using UnityEngine;
using System.Collections;

public class CreditsMoveScript : MonoBehaviour {

    private Transform m_Transform;
    private float m_Time = 0;
    private AudioSource m_Audio;
    

	// Use this for initialization
	void Start () {

        m_Transform = this.transform;
        m_Audio = GameObject.FindGameObjectWithTag("MainCamera")
            .GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

        m_Transform.Translate(Vector3.up * 75 * Time.deltaTime);

        if (m_Transform.position.y > 1300) {
            m_Time += Time.deltaTime;
            if (m_Time > 3.0f) {
                Application.LoadLevel("MenuScene");
            } else {
                m_Audio.volume = (3.0f - m_Time) / 3.0f;
            }

        }

	}
}
