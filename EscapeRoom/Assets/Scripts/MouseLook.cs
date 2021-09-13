using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //declaring the variable
    public float mouseSensitivity = 100;
    public Transform playerBody;
    float xRotation = 0;

    //removes the cursor from the screen and sets up the mouse sensitivty from the player settings
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if(PlayerPrefs.GetFloat("mouseSensitivity") != 0){
            mouseSensitivity = PlayerPrefs.GetFloat("mouseSensitivity");
        }
    }

    //uses mouse movement to move the camera of the player
    void Update()
    {
        if(PlayerPrefs.GetFloat("mouseSensitivity") != 0){
            mouseSensitivity = PlayerPrefs.GetFloat("mouseSensitivity");
        }
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
