using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    //public GameObject obj;
    public Renderer rend;
    
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name+":"+i);
    }
}
