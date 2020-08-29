using System.Collections;
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
        
        Debug.Log("Welcome to Number Wizard !");
        Debug.Log("Pick a number , and don't tell to me !");
        Debug.Log("Highest Number you can take is:" + max);
        Debug.Log("Lowest number you can take is:" + min);
        Debug.Log("Tell me that your number is greater or smaller than my 500! ");
         Debug.Log("Push Up = Higher , Push Down = Lower, Push Enter = Correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            Debug.Log(guess);
    
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("You hit Enter.");
        }
    }
}
