using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
	public float delayTime = 30;
	
	IEnumerator Start(){
		
		yield return new WaitForSeconds(delayTime);
		
		Application.LoadLevel("main");
	}
}
