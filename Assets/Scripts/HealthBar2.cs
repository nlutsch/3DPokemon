using UnityEngine;
using System.Collections;


public class HealthBar2 : MonoBehaviour
{
    private float maxHealth2 = 100;
    public float curHealth2 = 100;
	public float regeneration2 = 1;
    private float healthBarlength2;
    private int healthbarposition2;
    private float maxPP2 = 100;
    public float curPP2 = 100;
	public float ppregen2 = 10;
    private float ppBarlength2;
    private int ppBarposition2;
	private int livesPosition2;
	private int livesLength2;
	public int lives2;

    // Use this for initialization
    void Start()
    {
        healthBarlength2 = Screen.width / 2;
        ppBarlength2 = Screen.width / 2;
        healthbarposition2 = Screen.height / 2;
        ppBarposition2 = Screen.height / 2 + 20;
		livesPosition2 = Screen.height / 2 + 40;
		livesLength2 = 20;
		lives2 = 3;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustcurHealth2(0);
        AdjustcurPP2(ppregen2 / 100);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, healthbarposition2, healthBarlength2, 20), "Health " + (int)curHealth2 + "/" + maxHealth2);
        GUI.Box(new Rect(0, ppBarposition2, ppBarlength2, 20), "PP " + (int)curPP2 + "/" + maxPP2);
		GUI.TextArea (new Rect(0, livesPosition2, livesLength2, 20), lives2.ToString());
    }

    public void AdjustcurHealth2(float adj)
    {
        curHealth2 += adj;
        if (curHealth2 < 0)
            curHealth2 = 0;
        if (curHealth2 > maxHealth2)
            curHealth2 = maxHealth2;
        if (maxHealth2 < 1)
            maxHealth2 = 1;
        healthBarlength2 = (Screen.width / 2) * (curHealth2 / maxHealth2);
    }

    public void AdjustcurPP2(float adj)
    {
        curPP2 += adj;
        if (curPP2 < 0)
            curPP2 = 0;
        if (curPP2 > maxPP2)
            curPP2 = maxPP2;
        if (maxPP2 < 1)
            maxPP2 = 1;
        ppBarlength2 = (Screen.width / 2) * (curPP2 / maxPP2);
    }
	
	public void AdjLives2(int adj)
	{
		lives2--;
	}
}
