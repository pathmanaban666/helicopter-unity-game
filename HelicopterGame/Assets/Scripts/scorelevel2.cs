using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorelevel2 : MonoBehaviour
{
    public GameObject pipeloop;
    public Vector3 position;
    void Start()
    {
        StartCoroutine(pipeloopfunction());
    }
    IEnumerator pipeloopfunction(){
        while(true){
        yield return new WaitForSeconds(3f);
        float random=Random.Range(-1f,-5f);
        position=new Vector3(3f,random,0f);
        Instantiate(pipeloop,position,Quaternion.identity);
        }
    }  
}
