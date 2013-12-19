using UnityEngine;
using System.Collections;

public class CharAttcks : MonoBehaviour 
{

    public GameObject emberPrefab;
	public GameObject tacklePrefab2;
    public Camera c;
	GameObject charmanderObject;
	HealthBar2 adjhealthscript;
	private float movementSpeed2 = 1000.0f;
	private Vector3 moveDirection2 = Vector3.zero;
	
	void Start () {
		charmanderObject = GameObject.Find("Charmander Model");
		adjhealthscript = charmanderObject.GetComponent<HealthBar2>();
		
	} 
	
    void Update()
    {
        if (Input.GetButtonDown("Joystick 2A1") && adjhealthscript.curPP2 >= 10)
        {
            attackEmber();
        }
		
		if (Input.GetButtonDown ("Joystick 2A2") && adjhealthscript.curPP2 >= 5)
		{
			tackle();
		}
    }

    void attackEmber()
    {
        Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Object newEmber = Instantiate(emberPrefab, this.transform.position + charHeight, c.transform.rotation);
		Destroy (newEmber, .5f);
		
		GameObject emberModel = GameObject.Find ("Charmander Model");
		HealthBar2 Script1 = emberModel.GetComponent<HealthBar2>();
		Script1.AdjustcurPP2(-10);
    }
	
	public void tackle()
	{
		GameObject charModel = GameObject.Find ("Charmander Model");
		GameObject charEmpty = GameObject.Find ("Charmander");
		HealthBar2 Script1 = charModel.GetComponent<HealthBar2>();
		Script1.AdjustcurPP2(-5);
		
		Vector3 charHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
		Object newTackle = Instantiate(tacklePrefab2, this.transform.position + (charHeight / 2), this.transform.rotation);
		Destroy (newTackle, .2f);
		
		CharacterController cc2 = charEmpty.GetComponent<CharacterController>();
		moveDirection2 = new Vector3(0, 0, 1);
        moveDirection2 = transform.TransformDirection(moveDirection2);
        moveDirection2 *= movementSpeed2;
		cc2.SimpleMove(moveDirection2);	
	}
}
