using UnityEngine;
using System.Collections;

public class P1J : BaseController2 {
    
	void Start()
    {
		jump2 = "Jump 1J";
        rx2 = "Joystick RX1";
        ry2 = "Joystick RY1";
        lx2 = "Joystick LX1";
        ly2 = "Joystick LY1";
		//c2 = Resources.Load ("Camera1", Camera);
		//char2 = GameObject.Find ("Bulbasaur Model");
		//c2.transform.LookAt(char2);
        Screen.lockCursor = true;
    }
}
