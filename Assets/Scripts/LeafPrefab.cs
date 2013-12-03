using UnityEngine;
using System.Collections;

public class LeafPrefab : MonoBehaviour
{
    public float leafSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * leafSpeed);
    }
}
