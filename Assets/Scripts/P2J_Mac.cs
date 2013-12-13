using UnityEngine;
using System.Collections;

public class P2J_Mac : BaseController2 {

	// Use this for initialization
	void Start () {
		jump2 = "Jump 2JM";
        rx2 = "Joystick RX2M";
        ry2 = "Joystick RY2M";
        lx2 = "Joystick LX2";
        ly2 = "Joystick LY2";
		c2 = GameObject.Find ("camera2").camera;
		char2 = GameObject.Find ("Charmander Model");
		Screen.lockCursor = true;
	}
}
