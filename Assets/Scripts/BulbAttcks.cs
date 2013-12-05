using UnityEngine;
using System.Collections;

public class BulbAttcks : MonoBehaviour
{

    public GameObject leafPrefab;
    public Camera c;
	public HealthBar test;
	
    void Update()
    {
        if (Input.GetButtonDown("Joystick 1A1"))
        {
            attackLeaf();
        }
    }

    public void attackLeaf()
    {
        Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Instantiate(leafPrefab, this.transform.position + charHeight, c.transform.rotation);
		
		//GameObject.Find("Bulbasaur Model").GetComponent<HealthBar>();
		GameObject Object1 = GameObject.Find("Bulbasaur Model");
		HealthBar Script1 = Object1.GetComponent<HealthBar>();
		Script1.AdjustcurPP(-1);
    }
}
