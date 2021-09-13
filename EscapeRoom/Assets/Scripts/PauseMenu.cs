using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenu;
    public GameObject NumberPad1;
    public GameObject NumberPad2;
    public GameObject TextInput;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !NumberPad1.activeSelf && !NumberPad2.activeSelf && !TextInput.activeSelf){
            if(GameIsPause){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void MainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
