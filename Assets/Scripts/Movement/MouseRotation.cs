using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour {
	
	private void Update () {
        var cursorpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.LookAt(cursorpoint, Vector3.forward);

        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
	}
}
