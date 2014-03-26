using UnityEngine;	
using System.Collections;

public class FingerScript : MonoBehaviour {
	
	private GameObject m_current = null;
	
	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {

		
		if (Input.touchCount > 0 && m_current == null) {
			
			var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100)) {
				// Debug.DrawLine (ray.origin, hit.point);
				var objectHit = hit.collider.gameObject;
				if (objectHit.tag == "Ball")
					m_current = objectHit.gameObject;
				/*
                if(objectHit.tag == "Ball" && !objectHit.gameObject.GetComponent<BallScript>().angetouched){
                    m_current = objectHit.gameObject;
                    objectHit.gameObject.GetComponent<BallScript>().angetouched=true;
                }
                 * */
			}
		}

		if (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary)  && m_current != null) {
			var mp = new Vector3(0f, 0f, 1f);
			mp.y = Input.GetTouch(0).position.y + 50;
			var point = Camera.main.ScreenToWorldPoint(mp);
			point.x = Camera.main.transform.position.x;
			m_current.transform.position = point;
		}

		
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && m_current != null) {
			
			var mp = new Vector3(0f, 0f, 1f);
			mp.y = Input.GetTouch(0).position.y + 50;
			var point = Camera.main.ScreenToWorldPoint(mp);
			point.x = Camera.main.transform.position.x;
			m_current.transform.position = point;
			m_current.rigidbody.velocity = Vector3.zero;
			m_current.rigidbody.useGravity = true;
			m_current.rigidbody.AddForce(new Vector3(0, 1f, 1.35f) * 175.0f);
			
			m_current = null;
		}


		if (Input.GetMouseButtonDown(0) && m_current == null) {
            Debug.Log("Mouse down");
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100)) {
				Debug.DrawLine (ray.origin, hit.point);
				var objectHit = hit.collider.gameObject;
                if(objectHit.tag == "Ball")
                    m_current = objectHit.gameObject;
       
                
			}
		}

		if (Input.GetMouseButton(0) && m_current != null) {
			var mp = Input.mousePosition;
			mp.z = 1.0f;
            mp.x = Camera.main.transform.position.x;
			var point = Camera.main.ScreenToWorldPoint(mp);
            point.x = Camera.main.transform.position.x;
			m_current.transform.position = point;
		}

        if (Input.GetMouseButtonUp(0) && m_current != null) {
            m_current.rigidbody.velocity = Vector3.zero;
			m_current.rigidbody.useGravity = true;
			m_current.rigidbody.AddForce(new Vector3(0 + Random.Range(0.05f, -0.05f), 1f + Random.Range(0.05f, -0.05f), 1.35f + Random.Range(0.15f, -0.15f)) * 175.0f);
            m_current = null;
        }
        
		
		
		
	}
	
}
