using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            CloseButton();
        }
    }
    public void CloseButton(){
        this.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}
