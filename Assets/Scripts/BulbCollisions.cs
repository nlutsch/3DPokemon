using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour
{

    GameObject bulbasaurObject;
	HealthBar adjhealthscript;
    // Use this for initialization
    void Start()
    {
		bulbasaurObject = GameObject.Find("Bulbasaur Model");
		adjhealthscript = bulbasaurObject.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update(){
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ember")
           adjhealthscript.AdjustcurHealth(-5);
    }

}
