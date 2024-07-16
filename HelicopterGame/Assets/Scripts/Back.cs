using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{   
    public int CurrentLevel;
    public void GoMenu(){
        SceneManager.LoadScene(0);
    }
    public void PlayAgain(){
        CurrentLevel=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentLevel-5);
    }
    public void Nextlevel(){
        CurrentLevel=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentLevel-4);
    }
    public void levelMenu(){
        SceneManager.LoadScene(5);
    }
     public void instructions(){
        SceneManager.LoadScene(4);
    }
     public void startgame(){
        SceneManager.LoadScene(5);
        Time.timeScale=1f;
    } 
    public void quit(){
        Application.Quit();
    }

}
