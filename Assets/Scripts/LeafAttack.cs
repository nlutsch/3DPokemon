using UnityEngine;
using System.Collections;

public class LeafAttack : MonoBehaviour
{

    public float leafAttackSpeed = 1.5f;

    void Update()
    {
        this.transform.Translate(Vector3.forward * leafAttackSpeed);
    }

}

