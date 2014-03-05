using UnityEngine;
using System.Collections;

public class MovePlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime, Space.World);

        this.transform.Translate(Vector3.right * Input.acceleration.x * 5 * Time.deltaTime, Space.World);

        if (this.transform.position.x < -3.18f)
            this.transform.position = new Vector3(
                -3.18f,
                this.transform.position.y,
                this.transform.position.z);

        if (this.transform.position.x > 3.18f)
            this.transform.position = new Vector3(
                3.18f,
                this.transform.position.y,
                this.transform.position.z);


	}
}
