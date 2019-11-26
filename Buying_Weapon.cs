using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buying_Weapon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // A function which lets the player buy a Weapon
    // Uses a SWICH statement
    public void BuyingWeapon()
    {
        // If the gameObject name is relevant to the CASE
        // THEN switch
        switch (gameObject.name)
        {
            // If the moneyCounter is greater and equal to 50 AND the object name is equal to Weapon_1
            // THEN print text
            // Reduce 50 from the moneyCounter from the Player Script
            // Set the hasWeapon boolean to TRUE from the Player Script
            // OTHERWISE print text
            case "Weapon_1":
                if (FindObjectOfType<Player>().moneyCounter >= 50 && gameObject.name == "Weapon_1")
                {
                    Debug.Log("You purchased Weapon 1.");
                    FindObjectOfType<Player>().moneyCounter -= 50;
                    FindObjectOfType<Player>().hasWeapon = true;
                }

                else
                {
                    Debug.Log("You do not have enough money to buy this weapon!");
                }
                break;

            // If the moneyCounter is greater and equal to 100 AND the object name is equal to Weapon_2
            // THEN print text
            // Reduce 100 from the moneyCounter from the Player Script
            // Set the hasWeapon boolean to TRUE from the Player Script
            // OTHERWISE print text
            case "Weapon_2":
                if (FindObjectOfType<Player>().moneyCounter >= 100 && gameObject.name == "Weapon_2")
                {
                    Debug.Log("You purchased Weapon 2.");
                    FindObjectOfType<Player>().moneyCounter -= 100;
                    FindObjectOfType<Player>().hasWeapon = true;
                }

                else
                {
                    Debug.Log("You do not have enough money to buy this weapon!");
                }
                break;

            // If the moneyCounter is greater and equal to 1000 AND the object name is equal to Weapon_3
            // THEN print text
            // Reduce 1000 from the moneyCounter from the Player Script
            // Set the hasWeapon boolean to TRUE from the Player Script
            // OTHERWISE print text
            case "Weapon_3":
                if (FindObjectOfType<Player>().moneyCounter >= 1000 && gameObject.name == "Weapon_3")
                {
                    Debug.Log("You purchased Weapon 3.");
                    FindObjectOfType<Player>().moneyCounter -= 1000;
                    FindObjectOfType<Player>().hasWeapon = true;
                }

                else
                {
                    Debug.Log("You do not have enough money to buy this weapon!");
                }
                break;
        }
    }
}
