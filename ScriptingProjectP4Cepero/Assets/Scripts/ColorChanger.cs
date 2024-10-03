using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
      
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.cyan;   
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color= Color.magenta;
        }

        if( Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color=Color.white;
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color=Color.black;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color=Color.yellow;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color=Color.grey;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color=Color.clear;
        }
    }
}
