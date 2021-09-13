using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    //variable declaration for the radius of interaction and the transform
    public float radius = 3f;
    public Transform interactionTransform;
    //if no transform is found it takes the transform on its game object
    private void Start() {
        if(interactionTransform == null){
            interactionTransform = transform;
        }    
    }

}
