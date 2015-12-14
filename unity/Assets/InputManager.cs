using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public WindZone wind;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F)) {
			wind.windMain = 20;
		} else {
			wind.windMain = 0;
		}
	}
}
