using UnityEngine;
using System.Collections;

public class P1K : BaseController2
{

    void Start ()
    {
        jump2 = "Jump 1K";
        rx2 = "Mouse X";
        ry2 = "Mouse Y";
        lx2 = "Horizontal";
        ly2 = "Vertical";
		//c2 = GameObject.Find ("camera1").camera;
		//char2 = GameObject.Find ("Bulbasaur Model");
		Screen.lockCursor = true;
    }
}