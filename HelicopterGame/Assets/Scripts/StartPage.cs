using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour

{   
    public Button[] buttons; 
    void Awake()
    {
     int unlockedlevels=PlayerPrefs.GetInt("unlockedlevels",1);
     for(int i=0;i<3;i++){
     if(i+1>unlockedlevels){
         buttons[i].interactable=false;
     }
     }
    }
    public void level1(){
        SceneManager.LoadScene(1);
        Time.timeScale=1f;
    }
    public void level2(){
        SceneManager.LoadScene(2);
        Time.timeScale=1f;
    }
    public void level3(){
        SceneManager.LoadScene(3);
        Time.timeScale=1f;
    }
    public void BackGo(){
        SceneManager.LoadScene(0);
    }
    
}
