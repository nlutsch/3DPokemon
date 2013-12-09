using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
	private bool displayLabel = false;
	void Start(){
		//FlashStart();
		if (Input.GetButtonDown("Joystick 1A7") || Input.GetButtonDown("Joystick 2A7"))
        {
            Application.LoadLevel("main");
        }
	}
	
	//void FlashStart() {  
	//	bool stat = true;
     //   while (stat) {
     //         displayLabel = true;
     //         WaitForSeconds(.5);
     //         displayLabel = false;
      //        WaitForSeconds(.5);  
		//}
     //
}