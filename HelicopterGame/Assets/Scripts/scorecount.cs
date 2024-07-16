using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scorecount : MonoBehaviour
{   
    public int nextsceneload;
    private HelicopterScript Hsaccess;
    void Start()
    {
        Hsaccess=GameObject.Find("HelicopterPlane").GetComponent<HelicopterScript>();
        nextsceneload=SceneManager.GetActiveScene().buildIndex+1;
    }
    void OnTriggerEnter2D(Collider2D param){
        if(param.gameObject.tag=="Player"){
            Hsaccess.scoreupdate();
        }
        if(Hsaccess.score==50){
              SceneManager.LoadScene(nextsceneload+4);
              if(nextsceneload>PlayerPrefs.GetInt("unlockedlevels")){
                PlayerPrefs.SetInt("unlockedlevels",nextsceneload);
              }

        }

    }


}
