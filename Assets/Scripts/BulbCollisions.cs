using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour {

	GameObject bobj;
	HealthBar bhpb;
	string model = "Bulbasaur Model";
    string attack1 = "emberAttack";
	string attack2 = "Tackle2";
	private Vector3 startPosition = Vector3.zero;
    // Use this for initialization
    void Start()
    {
		bobj = GameObject.Find(model);
		bhpb = bobj.GetComponent<HealthBar>();
		startPosition = transform.position;
    }

    // Update is called once per frame
    void Update(){
		if (bhpb.curHealth <= 0) {
			transform.position = startPosition + new Vector3(0, 20, 0);
			bhpb.AdjustcurHealth (100);
			bhpb.AdjustcurPP(100);
			if (bhpb.lives == 1) Destroy(bobj);
			else bhpb.AdjLives(-1);
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == attack1)
            bhpb.AdjustcurHealth(-10);
		if (other.gameObject.tag == attack2)
			bhpb.AdjustcurHealth (-15);
    }

}