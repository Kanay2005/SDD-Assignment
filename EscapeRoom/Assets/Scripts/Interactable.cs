using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    private void Start() {
        if(interactionTransform == null){
            interactionTransform = transform;
        }    
    }
    public virtual void Interact(){
    }
}
