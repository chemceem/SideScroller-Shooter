using UnityEngine;
using System.Collections;

public class trackController : MonoBehaviour {

	//private variables
	private Transform _transform;
	private Vector2 _currentPosition;

	//public variables
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform>();
		this.Reset ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (speed,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -597) {
			Reset ();
		}
	}

	void Reset() {
		this._transform.position = new Vector2 (597f, -232);
	}
		
}
