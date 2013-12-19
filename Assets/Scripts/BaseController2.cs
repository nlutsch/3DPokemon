using UnityEngine;
using System.Collections;

public class BaseController2 : MonoBehaviour
{

    public float movementSpeed2 = 30.0f;
    public float mouseSensitivity2 = 2.0f;
    float verticalRotation2 = 0;
    public float upDownRange2 = 60.0f;
    public float jumpHeight2 = 5.0f;
    public string jump2;
    public string rx2;
    public string ry2;
    public string lx2;
    public string ly2;
    public Camera c2;
    public GameObject char2;
    private Vector3 moveDirection2 = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController cc2 = GetComponent<CharacterController>();

        // Rotation
        float rotLeftRight2 = Input.GetAxis(rx2) * mouseSensitivity2;
        transform.Rotate(0, rotLeftRight2, 0);
        char2.transform.Rotate(0, -rotLeftRight2, 0);

        verticalRotation2 += Input.GetAxis(ry2) * mouseSensitivity2;
        verticalRotation2 = Mathf.Clamp(verticalRotation2, -upDownRange2, upDownRange2);
        c2.transform.localRotation = Quaternion.Euler(verticalRotation2, 0, 0);

        // Movement
        moveDirection2 = new Vector3(Input.GetAxis(lx2), 0, Input.GetAxis(ly2));
        moveDirection2 = transform.TransformDirection(moveDirection2);
        moveDirection2 *= movementSpeed2;

        if (moveDirection2.magnitude > 0.05f)
        {
            char2.transform.LookAt(transform.position + moveDirection2);
        }

        // Jump
        if (Input.GetButtonDown(jump2) && cc2.isGrounded)
        {
            transform.position += transform.up * jumpHeight2;
            //modifiedJumperVelocity.y = jumpHeight2;
        }

        //if (!cc2.isGrounded)
        //{
        //   modifiedJumperVelocity.y -= gravity * Time.deltaTime;
        //    transform.position += new Vector3(modifiedJumperVelocity.x, modifiedJumperVelocity.y, 0);
        //}

        cc2.SimpleMove(moveDirection2);
    }
	
}
