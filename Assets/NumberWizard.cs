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

        StartGame();
              
    }

    //start the game 
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard | a fun game of Wits and Guess's");
        Debug.Log("Pick a Number        (and don't Tell me what it is )");
        Debug.Log("Pick something betweeen : " + max);
        Debug.Log("Something above  " + min);
        Debug.Log("Is Your Number :" + guess);
        Debug.Log("Push UP : if your number is Higher");
        Debug.Log("Push DOWN : if your number is lowwer");
        Debug.Log("Push ENTER : if the Number i Guessed it Right");
        max++;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("So it was this Huh :)  : " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it?? Higher or Lowwer now  >.>  : " + guess);
    }
}
