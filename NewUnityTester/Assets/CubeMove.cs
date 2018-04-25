using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {
    public Transform joystick;
    
	void Start () {

	}

	void Update () {
        transform.Translate(joystick.localPosition / 200);
	}
}
