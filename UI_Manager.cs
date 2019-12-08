using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public Text timerText;
    public Text scoreText;

    private int seconds;
    private int minutes;
    public int score;

    public Text merchantShopText;
    public Text buyingPotionText;
    public Image whiteBackground;
    public Image blackBackground;

    public Image inventoryBackground;
    public Image token;
    public Image potion;

    public Slider health;


    // Start is called before the first frame update
    void Start()
    {
        // Setting the UI components to false, to hide them at the start of the game
        merchantShopText.enabled = false;
        whiteBackground.enabled = false;
        blackBackground.enabled = false;
        buyingPotionText.enabled = false;
        inventoryBackground.enabled = false;
        token.enabled = false;
        potion.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Calling these functions to be run every frame
        DisplayTimer();
        DisplayScore();
        DisplayHealth();
    }

    // Displaying timer function
    // Setting the variable TIME to the variable TIMEr from the Timer script
    // Assigning MINUTES to the integer value of the TIME divided by 60
    // Assigning SECONDS to the iteger value of the remainder o TIME divided by 60
    public void DisplayTimer()
    {
        float time = GameObject.FindObjectOfType<Timer>().timer;
        minutes = Mathf.FloorToInt(time / 60.0f);
        seconds = Mathf.FloorToInt(time % 60.0f);

        // Altering the text for the timer textbox and displayin the timer by converting the values from integer to strings
        timerText.text = minutes.ToString() + " : " + seconds.ToString();
    }

    // Displaying score function
    // Alternates the score text to the actual score for the player
    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
    }

    // Displaying the shop text
    // Shows all the UI components for displaying the shop text
    // Alternates the text for the merchant shop textbox
    public void DisplayShopText1()
    {
        merchantShopText.enabled = true;
        whiteBackground.enabled = true;
        blackBackground.enabled = true;
        merchantShopText.text = "Here you can buy some potions! To buy some please get me a token.";
    }

    // Deletes the merchant text function
    public void DeleteMerchantText1()
    {
        merchantShopText.enabled = false;
        whiteBackground.enabled = false;
        blackBackground.enabled = false;
    }

    // Displays the potion text
    public void DisplayPotionText()
    {
        buyingPotionText.enabled = true;
        whiteBackground.enabled = true;
        blackBackground.enabled = true;
        buyingPotionText.text = "Press B to buy potion!";           // Alternates the buying potion text 
    }

    // Deletes the potion text
    public void DeletePotionText()
    {
        buyingPotionText.enabled = false;
        whiteBackground.enabled = false;
        blackBackground.enabled = false;
    }

    // Displays the inventory
    public void DisplayInventory()
    {
        inventoryBackground.enabled = true;

        // If the player has token then enable the image for token
        if (FindObjectOfType<Player>().hasToken)
        {
            token.enabled = true;
        }
    }

    // Buying potion funtion
    // Disables the potion image and destroys the token image
    public void BuyingPotion()
    {
        token.enabled = false;
        potion.enabled = true;
    }

    // Displays the health for the player
    // Alternates the value for the healthbar by getting the health value from the Player script and divide it by 100
    public void DisplayHealth()
    {
        health.value = FindObjectOfType<Player>().health / 100.0f;
    }


}
