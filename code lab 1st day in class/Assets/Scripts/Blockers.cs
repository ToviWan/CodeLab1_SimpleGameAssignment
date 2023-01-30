using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Blockers : MonoBehaviour
{
    public float frequency = 1f;    //movement speed
    public float amplitude = 1f;    //movement amount
    Vector3 startPos;
    float elapsedTime = 0f;

    public Vector3 dropSpeed = new Vector3(0,.1f,0);
    // Use t$$anonymous$$s for initialization
    void Start () {
        startPos = transform.position;
    }
    // Update is called once per frame
    void Update () {
        elapsedTime += Time.deltaTime * Time.timeScale * frequency;
        transform.position -= dropSpeed;
        
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-29f,16f),startPos.y,startPos.z);
        
    }
}
