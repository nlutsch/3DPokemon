using UnityEngine;
using System.Collections;

public class BulbAttcks : MonoBehaviour
{

    public GameObject leafPrefab;
	public GameObject tacklePrefab1;
    public Camera c;
	GameObject bulbasaurObject;
	HealthBar adjhealthscript;
	private float movementSpeed2 = 1000.0f;
	private Vector3 moveDirection2 = Vector3.zero;
	private int cycles = 0;
	private Vector3 force = new Vector3(0, -10000F, 0);
	
	
	void Start () {
		bulbasaurObject = GameObject.Find("Bulbasaur Model");
		adjhealthscript = bulbasaurObject.GetComponent<HealthBar>();
		
	}
	
    void Update()
    {
        if (Input.GetButtonDown("Joystick 1A1") && adjhealthscript.curPP >= 10)
        {
            attackLeaf();
        }
		
		if (Input.GetButtonDown ("Joystick 1A2") && adjhealthscript.curPP >= 5)
		{
			cycles = 0;
			tackle();
		}
		
		if (cycles < 300) 
		{
			rigidbody.AddForce (force, ForceMode.Force);
			cycles++;
		}
    }

    public void attackLeaf()
    {
        Vector3 bulbHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
        Object newLeaf = Instantiate(leafPrefab, this.transform.position + bulbHeight, c.transform.rotation);
		Destroy (newLeaf, .5f);
		
		GameObject bulbModel = GameObject.Find ("Bulbasaur Model");
		HealthBar Script1 = bulbModel.GetComponent<HealthBar>();
		Script1.AdjustcurPP(-10);
    }
	
	public void tackle()
	{
		GameObject bulbModel = GameObject.Find ("Bulbasaur Model");
		GameObject bulbEmpty = GameObject.Find ("Bulbasaur");
		HealthBar Script1 = bulbModel.GetComponent<HealthBar>();
		Script1.AdjustcurPP(-5);
		
		Vector3 bulbHeight = new Vector3(1f * c.transform.rotation.x, 2.1f, 1.5f * c.transform.rotation.z);
		Object newTackle = Instantiate(tacklePrefab1, this.transform.position + (bulbHeight / 2), this.transform.rotation);
		Destroy (newTackle, .3f);
		
		CharacterController cc2 = bulbEmpty.GetComponent<CharacterController>();
		moveDirection2 = new Vector3(0, 0, 1);
        moveDirection2 = transform.TransformDirection(moveDirection2);
        moveDirection2 *= movementSpeed2;
		cc2.SimpleMove(moveDirection2);	
	}
}
