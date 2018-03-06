using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public string btnName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (btnName)) {
			Debug.Log("alhamdulillah");
		}
		if (Input.GetButtonUp (btnName)) {
			Debug.Log("OK");
		}
	}
}
