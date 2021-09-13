using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variable declaration for the script
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    public Camera cam;

    Vector3 velocity;
    bool isGrounded;
    public 

    //gets the input for the movement and moves the playes accordingly
    //also looks for the press of the left and the right mouse button and calls the function for the iteraction of items
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if(Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 10)){
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null){
                    try{
                        hit.transform.gameObject.GetComponent<ItemInteract>().Interact();
                    }
                    catch{}
                }
            }
        }

        if(Input.GetMouseButtonDown(1)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 10)){
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null){
                    try{
                        hit.transform.gameObject.GetComponent<ItemPickup>().PickUp();
                    }
                    catch{}
                }
            }
        }
    }
}
