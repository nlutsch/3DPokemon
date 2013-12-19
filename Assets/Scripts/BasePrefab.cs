using UnityEngine;
using System.Collections;

public class BasePrefab : MonoBehaviour {

    public float pspeed = 3f;

	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * pspeed);
	}
}
