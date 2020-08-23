﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, new Vector3(2,0,0), new Quaternion(0,0,0,0));
        Instantiate(blueObj, new Vector3(-2,0,0), new Quaternion(0,0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;
}
