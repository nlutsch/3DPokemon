using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour {

	GameObject bobj;
	HealthBar bhpb;
	string model = "Bulbasaur Model";
    string attack = "emberAttack";
    // Use this for initialization
    void Start()
    {
		bobj = GameObject.Find(model);
		bhpb = bobj.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update(){
		if (bhpb.curHealth <= 0) {
			Destroy(bobj);
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == attack)
           bhpb.AdjustcurHealth(-10);
    }

}