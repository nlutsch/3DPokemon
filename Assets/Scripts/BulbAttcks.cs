using UnityEngine;
using System.Collections;

public class BulbAttcks : MonoBehaviour
{

    public GameObject leafPrefab;
    public Camera c;
	GameObject bulbasaurObject;
	HealthBar adjhealthscript;
	// Use this for initialization
	void Start () {
		bulbasaurObject = GameObject.Find("Bulbasaur Model");
		adjhealthscript = bulbasaurObject.GetComponent<HealthBar>();
	}
	
    void Update()
    {
        if (Input.GetButtonDown("Joystick 1A1") && adjhealthscript.curPP >= 10)
        {
            attackLeaf();
        }
    }

    public void attackLeaf()
    {
        Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Instantiate(leafPrefab, this.transform.position + charHeight, c.transform.rotation);
		
		//GameObject.Find("Bulbasaur Model").GetComponent<HealthBar>();
		GameObject bulbModel = GameObject.Find("Bulbasaur Model");
		HealthBar Script1 = bulbModel.GetComponent<HealthBar>();
		Script1.AdjustcurPP(-10);
    }
}
