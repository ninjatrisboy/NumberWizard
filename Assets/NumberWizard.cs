﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour{

    // Start is called before the first frame update
    void Start() {
        int max = 1000;
        int min = 1;
        
        Debug.Log("Welcome to number wizard yo");
        Debug.Log("I want you to pick a number");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
