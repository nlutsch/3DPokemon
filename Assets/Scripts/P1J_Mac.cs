using UnityEngine;
using System.Collections;

public class P1J_Mac : BaseController2 {

	// Use this for initialization
	void Start () {
		jump2 = "Jump 1JM";
        rx2 = "Joystick RX1M";
        ry2 = "Joystick RY1M";
        lx2 = "Joystick LX1";
        ly2 = "Joystick LY1";
		c2 = GameObject.Find ("camera1").camera;
		char2 = GameObject.Find ("Bulbasaur Model");
		Screen.lockCursor = true;
	}
}
