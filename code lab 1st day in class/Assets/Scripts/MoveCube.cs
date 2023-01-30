using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCube : MonoBehaviour
{
    public float speed = 1f;
    public float x;
    public float y;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}
