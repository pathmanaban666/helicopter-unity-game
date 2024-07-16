using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelicopterScript : MonoBehaviour

{
    private Rigidbody2D rigid; 
    public float jump=2f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public Text textscore,textscoreboard,TextScoreResume;
    public float score;
    public GameObject retry,pausebtn,text1,text2,JumpUpObject;
  
    void Start()
    {
        score=0f;
        rigid=GetComponent<Rigidbody2D>();
    }
    void Update()
    {  
       Vector3 currentpos=transform.position;
       currentpos.x=Mathf.Clamp(currentpos.x,minX,maxX);
       currentpos.y=Mathf.Clamp(currentpos.y,minY,maxY);
       transform.position=currentpos;
    }
    public void JumpUp(){
        rigid.velocity=new Vector2(0f,jump);
    }
    void OnCollisionEnter2D(Collision2D obj){
         if(obj.gameObject.tag=="pipe"){
          Time.timeScale=0f;
          retry.SetActive(true);
          text1.SetActive(false);
          text2.SetActive(false);
          pausebtn.SetActive(false);
          JumpUpObject.SetActive(false);
         } 
    }
    public void scoreupdate(){
        score=score+1f;
        textscore.text=score.ToString();
        textscoreboard.text=score.ToString();
        TextScoreResume.text=score.ToString();
     }
      public void retrygame(){
          retry.SetActive(false);
          JumpUpObject.SetActive(true);
          Time.timeScale=1f;
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          
    }
    
}
