using UnityEngine;
using System.Collections;

public class CityController : MonoBehaviour {


	//Private Variable
	private Transform _transform;
	private Vector2 _currentPosition;

	//public variables
	public float speed = 1f;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform>();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (speed, 0);
		this._transform.position = this._currentPosition;
		Debug.Log ("position" + this._currentPosition.x);

		if (this._currentPosition.x <= -598) {
			Reset ();
		}
	}

	void Reset() {
		this._transform.position = new Vector2 (600f, 0);
	}
		
}
