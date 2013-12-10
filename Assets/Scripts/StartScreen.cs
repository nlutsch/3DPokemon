using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
	//private bool displayLabel = false;
	void Start () {
		//FlashStart();
		;
	}
	 void Update () {
		if (Input.GetButtonDown("Start 1") || Input.GetButtonDown("Start 2"))
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