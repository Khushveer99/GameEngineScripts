using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController player;

    public bool hasToken;
    public bool isBuyingPotion;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        // Setting buying potion to FALSE
        isBuyingPotion = false;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is buying the potion
        // And if the player presses 'b' key the call the Buying Potion function from the UI script
        if (isBuyingPotion)
        {
            if (Input.GetKey("b"))
            {
                FindObjectOfType<UI_Manager>().BuyingPotion();
            }
        }
    }

    // When the player enters a collder function
    private void OnTriggerEnter(Collider other)
    {
        // If the player collides with the collider called SHOP
        // Then call the Display Shop Text function from the UI script
        if (other.gameObject.tag == "Shop")
        {
            FindObjectOfType<UI_Manager>().DisplayShopText1();
        }

        // If the player collides with the collider called TOKEN
        // Then call the Display Invenroty funciton from the UI script
        // Find the variable SCORE rom the UI script and add 1 
        if (other.gameObject.tag == "Token")
        {
            Destroy(other.gameObject);
            hasToken = true;
            FindObjectOfType<UI_Manager>().DisplayInventory();
            FindObjectOfType<UI_Manager>().score++;
        }

        // If the player collides with the collider called POTION
        // Then call the Display Potion Text function from the UI script
        // Set the boolean buyi potion to TRUE
        if (other.gameObject.tag == "Potion")
        {
            FindObjectOfType<UI_Manager>().DisplayPotionText();
            isBuyingPotion = true;
        }

        // If the player collides with the collider called ENEMY
        // Subtract 20 from the health
        if (other.gameObject.tag == "Enemy")
        {
            health -= 20;
        }

    }

    // Funtion for when the player leaves the collider box
    private void OnTriggerExit(Collider other)
    {
        // If the player leaves the collider called SHOP
        // Call the function Delete Merchant Text from the UI script
        if (other.gameObject.tag == "Shop")
        {
            FindObjectOfType<UI_Manager>().DeleteMerchantText1();
        }

        // If the player leaves the collider called Potion Trigger
        // Call the function Delete Potion Text from the UI script
        if (other.gameObject.name == "Buy_Potion_Trigger")
        {
            FindObjectOfType<UI_Manager>().DeletePotionText();
        }
    }
}
