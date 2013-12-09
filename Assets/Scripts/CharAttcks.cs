using UnityEngine;
using System.Collections;

public class CharAttcks : MonoBehaviour {

    public GameObject emberPrefab;
    public Camera c;

    void Update()
    {
        if (Input.GetButtonDown("Joystick 2A1"))
        {
            attackEmber();
        }
    }

    void attackEmber()
    {
        Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Instantiate(emberPrefab, this.transform.position + charHeight, c.transform.rotation);
		GameObject emberModel = GameObject.Find("Charmander Model");
		HealthBar2 Script1 = emberModel.GetComponent<HealthBar2>();
		Script1.AdjustcurPP2(-10);
    }
}
