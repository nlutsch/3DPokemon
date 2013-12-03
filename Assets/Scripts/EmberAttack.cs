using UnityEngine;
using System.Collections;

public class EmberAttack : MonoBehaviour {

    public float emberAttackSpeed = 1.5f;
	
	void Update () {
        this.transform.Translate(Vector3.forward * emberAttackSpeed);
	}
}
