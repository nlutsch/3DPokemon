using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListAttacks : MonoBehaviour{

    public static Dictionary<string, Attack> listOfAttacks;
    

    public ListAttacks() {
        Dictionary<string, Attack> listOfAttacks = new Dictionary<string, Attack>();
        listOfAttacks.Add("ember", new Attack("ember", "fire", 20f, 20f, 5f, 0f));
    }

    public Attack GetAttack(string a) {
        return listOfAttacks["a"];
    }
}

public class Attack : MonoBehaviour {
    public string type;
    public float power;
    public float range;
    public float pp;
    public float move;
    public GameObject pref;

    public Attack(string n, string t, float p, float r, float ps, float m)
    {
        type = t;
        power = p;
        range = r;
        pp = ps;
        move = m;     
    }

    public Attack() { ;}

    public void PerformAttack() {
        Instantiate(pref, this.transform.position, this.transform.rotation);
    }
}
