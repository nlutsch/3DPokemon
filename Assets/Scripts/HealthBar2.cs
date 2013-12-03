using UnityEngine;
using System.Collections;


public class HealthBar2 : MonoBehaviour
{
    private int maxHealth2 = 100;
    public int curHealth2 = 100;
    private float healthBarlength2;
    private int healthbarposition2;
    private int maxPP2 = 100;
    public int curPP2 = 100;
    private float ppBarlength2;
    private int ppBarposition2;

    // Use this for initialization
    void Start()
    {
        healthBarlength2 = Screen.width / 2;
        ppBarlength2 = Screen.width / 2;
        healthbarposition2 = Screen.height / 2;
        ppBarposition2 = Screen.height / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustcurHealth2(0);
        AdjustcurPP2(0);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, healthbarposition2, healthBarlength2, 20), "Health" + curHealth2 + "/" + maxHealth2);
        GUI.Box(new Rect(Screen.width / 2, ppBarposition2, ppBarlength2, 20), "PP" + curPP2 + "/" + maxPP2);
    }

    public void AdjustcurHealth2(int adj)
    {
        curHealth2 += adj;
        if (curHealth2 < 0)
            curHealth2 = 0;
        if (curHealth2 > maxHealth2)
            curHealth2 = maxHealth2;
        if (maxHealth2 < 1)
            maxHealth2 = 1;
        healthBarlength2 = (Screen.width / 2) * (curHealth2 / (float)maxHealth2);
    }

    public void AdjustcurPP2(int adj)
    {
        curPP2 += adj;
        if (curPP2 < 0)
            curPP2 = 0;
        if (curPP2 > maxPP2)
            curPP2 = maxPP2;
        if (maxPP2 < 1)
            maxPP2 = 1;
        ppBarlength2 = (Screen.width / 2) * (curPP2 / (float)maxPP2);
    }
}
