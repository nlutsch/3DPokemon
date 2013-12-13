using UnityEngine;
using System.Collections;

public class P2K : BaseController2 {
    void Start ()
    {
        jump2 = "Jump 2J";
        rx2 = "Joystick RX2";
        ry2 = "Joystick RY2";
        lx2 = "Joystick LX2";
        ly2 = "Joystick LY2";
		c2 = GameObject.Find ("camera2").camera;
		char2 = GameObject.Find ("Charmander Model");
		Screen.lockCursor = true;
    }
}