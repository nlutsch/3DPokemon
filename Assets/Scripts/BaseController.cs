using UnityEngine;
using System.Collections;

public class BaseController : MonoBehaviour {

    public float movementSpeed = 70.0f;
    public float mouseSensitivity = 2.0f;
    float verticalRotation = 0;
    public float upDownRange = 60.0f;
    public float jumpHeight = 10.0f;
    public string jump;
    public string rx;
    public string ry;
    public string lx;
    public string ly;
    //public string a1;
    //public string a2;
    //public string a3;
    //public string a4;
    //public Attack att1;
    //public Attack att2;
    //public Attack att3;
    //public Attack att4;
    public Camera c;
    public Vector3 moveDirection = Vector3.zero;
 
	// Use this for initialization
	void Start () {
        Screen.lockCursor = true;
        //c.transform.localPosition = new Vector3(-10f, 10f, 0f);
	}
	
	// Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetButtonDown(jump))
        {
            transform.Translate(0, jumpHeight, 0);
        }

        // Rotation
        float rotLeftRight = Input.GetAxis(rx) * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation += Input.GetAxis(ry) * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        c.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Movement
        float forwardSpeed = -Input.GetAxis(ly) * movementSpeed;
        float sideSpeed = Input.GetAxis(lx) * movementSpeed;
        //if (Input.GetButtonDown("Vertical 2"))
        //{
        //    forwardSpeed = Input.GetAxis("Vertical 2") * movementSpeed;
        //}

        //if (Input.GetButtonDown("Horizontal 2"))
        //{
        //    forwardSpeed = Input.GetAxis("Horizontal 2") * movementSpeed;
        //}

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController cc = GetComponent<CharacterController>();

        cc.SimpleMove(speed);
    }

        void OnControllerColliderHit(ControllerColliderHit other)
        {
            if (other.collider.gameObject.tag == "ember")
                Destroy(gameObject);
            if (other.collider.gameObject.tag == "leaf")
                Destroy(gameObject);
        }
}
