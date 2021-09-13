using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //variable declaration for the script
    public static bool GameIsPause = false;
    public GameObject pauseMenu;
    public GameObject NumberPad1;
    public GameObject NumberPad2;
    public GameObject TextInput;
    //used to listen for the press of the escape key and checks if any other menu is open
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
    //goes back to the game
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    //used to pause the game and being up the menu
    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
    }
    //used to go back to the main menu of the game
    public void MainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
