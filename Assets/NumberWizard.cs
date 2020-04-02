using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
       
        
        Debug.Log("Welcome to number Wizard, yo");
        Debug.Log("Pick a Number  (Dont Tell me Baka )");
        Debug.Log("Highest number it could be is : " + max);
        Debug.Log("Lowest number it can be is : " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push UP : if the Number i Geussed is High");
        Debug.Log("Push DOWN : if the Number i Guessed is Low");
        Debug.Log("Push ENTER : if the Number i Guessed was Correct");

        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (min + max) / 2;
            Debug.Log(guess);
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
            max = guess;
            guess = (min + max) / 2;
            Debug.Log(guess);
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER was pressed");
        }
    }
}
