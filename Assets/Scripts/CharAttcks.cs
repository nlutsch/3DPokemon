using UnityEngine;
using System.Collections;

public class CharAttcks : MonoBehaviour 
{

    public GameObject emberPrefab;
    public Camera c;
	GameObject charmanderObject;
	HealthBar2 adjhealthscript;
	
	void Start () {
		charmanderObject = GameObject.Find("Charmander Model");
		adjhealthscript = charmanderObject.GetComponent<HealthBar2>();
	} 
	
    void Update()
    {
        if (Input.GetButtonDown("Joystick 2A1") && adjhealthscript.curPP2 >= 10)
        {
            attackEmber();
        }
    }

    void attackEmber()
    {
        Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Object newEmber = Instantiate(emberPrefab, this.transform.position + charHeight, c.transform.rotation);
		Destroy (newEmber, .5f);
		
		
		GameObject emberModel = GameObject.Find("Charmander Model");
		HealthBar2 Script1 = emberModel.GetComponent<HealthBar2>();
		Script1.AdjustcurPP2(-10);
    }
}
