using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour
{

    GameObject bulbasaurObject;
	HealthBar adjhealthscript2;
    // Use this for initialization
    void Start()
    {
		bulbasaurObject = GameObject.Find("Bulbasaur Model");
		adjhealthscript2 = bulbasaurObject.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update(){
		if (adjhealthscript2.curHealth <= 0) {
			Destroy(bulbasaurObject);
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "emberAttack")
           adjhealthscript2.AdjustcurHealth(-10);
    }

}
