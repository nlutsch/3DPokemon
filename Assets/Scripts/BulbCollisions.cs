using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour {

	GameObject bobj;
	HealthBar bhpb;
	string model = "Bulbasaur Model";
    string attack1 = "emberAttack";
	string attack2 = "Tackle2";
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
        if (other.gameObject.tag == attack1)
            bhpb.AdjustcurHealth(-10);
		if (other.gameObject.tag == attack2)
			bhpb.AdjustcurHealth (-15);
		Debug.Log(other.gameObject.tag);
    }

}