using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeloopScript : MonoBehaviour
{
    public GameObject pipeloop;
    public Vector3 position;
    void Start()
    {
        StartCoroutine(pipeloopfunction());
    }
    IEnumerator pipeloopfunction(){
        while(true){
        yield return new WaitForSeconds(4f);
        float random=Random.Range(-1f,-5f);
        position=new Vector3(4f,random,0f);
        Instantiate(pipeloop,position,Quaternion.identity);
        }
    }  
}
