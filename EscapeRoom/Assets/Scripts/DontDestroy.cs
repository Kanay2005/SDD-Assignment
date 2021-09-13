using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DontDestroy : MonoBehaviour
{
    
    void Awake()
    {
        //finds the objects with the tag of "Music" and if more than one is found destroys the object
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1){
            Destroy(this.gameObject);
        }
        //keeps one objects to stay between scenes
        DontDestroyOnLoad(this.gameObject);
    }

}
