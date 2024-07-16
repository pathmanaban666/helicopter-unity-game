using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeloop3 : MonoBehaviour
{
 public GameObject pipeloop;
    public Vector3 position;
    void Start()
    {
        StartCoroutine(pipeloopfunction());
    }
    IEnumerator pipeloopfunction(){
        while(true){
        yield return new WaitForSeconds(2.5f);
        float random=Random.Range(-1f,-5f);
        position=new Vector3(2f,random,0f);
        Instantiate(pipeloop,position,Quaternion.identity);
        }
    }  
}
