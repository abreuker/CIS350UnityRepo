using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Anna Breuker
* Assignment 5B
* This script is reposnible for the camera looking around based on mouse movement.
*/

public class MouseLook : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public GameObject player;
	private float verticalLookRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

	private void OnApplicaitonFocus(bool focus)
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		//rotate player GameObject with hori mouse input
		player.transform.Rotate(Vector3.up * mouseX);

		//rotate camera around the x axis with vertical mouse input
		verticalLookRotation -= mouseY;

		verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);


    }

}
