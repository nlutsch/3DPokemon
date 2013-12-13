using UnityEngine;
using System.Collections;

public class BasePrefab : MonoBehaviour {

    private float speed = 3f;

	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * speed);
	}
}
