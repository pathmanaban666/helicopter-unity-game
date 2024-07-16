using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour

{
    public float speed = -3f;
    void Update()
    {
        transform.Translate(speed*Time.deltaTime,0f,0f);
    }
}
