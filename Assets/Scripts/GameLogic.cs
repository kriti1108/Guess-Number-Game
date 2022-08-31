using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField userInputValue;
    private int randomNumber;
    public Text gameLabel;
    public Button gameButton;
    public Button startButton;
    public Button quitButton;
    public Text count;
    int count1 = 0;
    void Start()
    {
        resetgame();
    }
    void resetgame(){
        count1 = 0;
        count.text = count1.ToString();
        randomNumber = Random.Range(0,101);
        gameLabel.text = "The Game Begins! \n Try a number between 0 and 100";
        userInputValue.text = "";
   
        
    }
    public void onStartButtonClick(){
        resetgame();
    }
    public void onQuitButtonClick(){
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void onButtonClick(){
        string userInput = userInputValue.text;
        /*
        ans *=2;
        Debug.Log("twice the value entered is "+ ans);
        Debug.Log("The Game Begins!");
        Debug.Log(userInputValue.text);
        Debug.Log("The random number is "+ randomNumber);
        */
        if(userInput!=""){
        int ans = int.Parse(userInput);
        if(ans==randomNumber)
        {
            Debug.Log("Correct");
            gameLabel.text = "You won the game!";
            count.text = count1.ToString();
            count1 = 0;
            //gameButton.interactable = false;
        }
        else if(ans>randomNumber){
            Debug.Log("Try smaller");
            gameLabel.text = "Try smaller...";
            count1++;
            count.text =count1.ToString();
            

        }
        else{
            Debug.Log("Try Higher");
            gameLabel.text = "Try higher...";
            count1++;
            count.text =count1.ToString();
        }
        }
        if(userInput==""){
            gameLabel.text = "Please Enter a number between 0 and 100";
            Debug.Log("Enter an integer");
        }
    }
}
