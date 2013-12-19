using UnityEngine;
using System.Collections;


public class HealthBar : MonoBehaviour
{
    private float maxHealth = 100;
    public float curHealth = 100;
	public float regeneration = 1;
    private float healthBarlength;
    private int healthbarposition;
    private float maxPP = 100;
    public float curPP = 100;
	public float ppRegen = 10;
    private float ppBarlength;
    private int ppBarposition;
	private int livesPosition;
	private int livesLength;
	public int lives;

    // Use this for initialization
    void Start()
    {
        healthBarlength = Screen.width / 2;
        ppBarlength = Screen.width / 2;
        healthbarposition = 0;
        ppBarposition = 20;
		livesPosition = 40;
		livesLength = 20;
		lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustcurPP(ppRegen / 100);
		AdjustcurHealth (0);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, healthbarposition, healthBarlength, 20), "Health " + (int)curHealth + "/" + maxHealth);
        GUI.Box(new Rect(0, ppBarposition, ppBarlength, 20), "PP " + (int)curPP + "/" + maxPP);
		GUI.TextArea (new Rect(0, livesPosition, livesLength, 20), lives.ToString());
    }

    public void AdjustcurHealth(float adj)
    {
        curHealth += adj;
        if (curHealth < 0)
            curHealth = 0;
        if (curHealth > maxHealth)
            curHealth = maxHealth;
        if (maxHealth < 1)
            maxHealth = 1;
        healthBarlength = (Screen.width / 2) * (curHealth / maxHealth);
    }

    public void AdjustcurPP(float adj)
    {
        curPP += adj;
        if (curPP < 0)
            curPP = 0;
        if (curPP > maxPP)
            curPP = maxPP;
        if (maxPP < 1)
            maxPP = 1;
        ppBarlength = (Screen.width / 2) * (curPP / maxPP);
    }
	
	public void AdjLives(int adj)
	{
		lives--;
	}
}