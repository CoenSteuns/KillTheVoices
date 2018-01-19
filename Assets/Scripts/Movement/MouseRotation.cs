using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var cursorpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(cursorpoint, Vector3.forward);
	}
}
