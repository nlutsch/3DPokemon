using UnityEngine;
using System.Collections;

public class BulbCollisions : MonoBehaviour
{

    public HealthBar hp;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ember")
            hp.AdjustcurHealth(10);
    }

}
