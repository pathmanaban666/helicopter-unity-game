using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{   
    public GameObject pausebtn,panel,text3,text4,JumpUp;
    public void pause(){
        Time.timeScale=0f;
        panel.SetActive(true);
        pausebtn.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        JumpUp.SetActive(false);
    }
    public void play(){
        Time.timeScale=1f;
        pausebtn.SetActive(true);
        panel.SetActive(false);
        text3.SetActive(true);
        text4.SetActive(true);
        JumpUp.SetActive(true);
    }
    public void GoMenu(){
        SceneManager.LoadScene(5);
    }
}
