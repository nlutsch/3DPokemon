using UnityEngine;
using System.Collections;

public class EmberPrefab : MonoBehaviour {

    public float emberSpeed = 3f;

	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * emberSpeed);
	}
}
