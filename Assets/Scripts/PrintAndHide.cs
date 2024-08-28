using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    //public GameObject obj;
    public Renderer rend;
    
    private int i;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        a = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name+":"+i);
        if (gameObject.CompareTag("Red") & i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") & i == a)
        {
            //rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
    }
}
