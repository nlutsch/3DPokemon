using UnityEngine;
using System.Collections;


public class HealthBar : MonoBehaviour
{
    private int maxHealth = 100;
    public int curHealth = 100;
    private float healthBarlength;
    private int healthbarposition;
    private int maxPP = 100;
    public int curPP = 100;
    private float ppBarlength;
    private int ppBarposition;

    // Use this for initialization
    void Start()
    {
        healthBarlength = Screen.width / 2;
        ppBarlength = Screen.width / 2;
        healthbarposition = 0;
        ppBarposition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustcurHealth(0);
        AdjustcurPP(0);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, healthbarposition, healthBarlength, 20), "Health" + curHealth + "/" + maxHealth);
        GUI.Box(new Rect(Screen.width / 2, ppBarposition, ppBarlength, 20), "PP" + curPP + "/" + maxPP);
    }

    public void AdjustcurHealth(int adj)
    {
        curHealth += adj;
        if (curHealth < 0)
            curHealth = 0;
        if (curHealth > maxHealth)
            curHealth = maxHealth;
        if (maxHealth < 1)
            maxHealth = 1;
        healthBarlength = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }

    public void AdjustcurPP(int adj)
    {
        curPP += adj;
        if (curPP < 0)
            curPP = 0;
        if (curPP > maxPP)
            curPP = maxPP;
        if (maxPP < 1)
            maxPP = 1;
        ppBarlength = (Screen.width / 2) * (curPP / (float)maxPP);
    }
}