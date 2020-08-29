﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberwizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;


    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Hey, Let's Play Number Wizard! ");
        Debug.Log("Pick a number , and don't tell to me !");
        Debug.Log("Highest Number you can take is:" + max);
        Debug.Log("Lowest number you can take is:" + min);
        Debug.Log("Tell me that your number is greater or smaller than:" + guess);
         Debug.Log("Push Up = Higher , Push Down = Lower, Push Enter = Correct");
         max = max + 1 ;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           min = guess;
           guess = ( max + min ) / 2;
           Debug.Log("Is it Higher or Lower than....." + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
           
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it Higher or Lower than..... "+ guess);
    
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I know i am a Genius.");
        }
    }
}
