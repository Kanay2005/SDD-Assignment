using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100;
    public Transform playerBody;
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if(PlayerPrefs.GetFloat("mouseSensitivity") != 0){
            mouseSensitivity = PlayerPrefs.GetFloat("mouseSensitivity");
        }
    }

    // Update is called once per frame
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
