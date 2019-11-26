using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public ControllerColliderHit player_character;          // Assigning ControllerColliderHit component to player
    public int playerHealth = 100;
    public int moneyCounter = 0;

    public bool hasWeapon = false;

    private Enemy enemy;
    private Money money;
    private Gems gem;
    private Key key;
    private Buying_Weapon weapon;


    // Start is called before the first frame update
    void Start()
    {
        // Finding the object script and assigning it to each corresponding variable
        enemy = FindObjectOfType<Enemy>();
        money = FindObjectOfType<Money>();
        gem = FindObjectOfType<Gems>();
        key = FindObjectOfType<Key>();
        weapon = FindObjectOfType<Buying_Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When player controller collider COLLIDES with another object
    // Using a SWITCH statement
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       // Switch each CASE string with the SWITCH statement
       // This is when the player collides with the corresponding object
       switch (hit.gameObject.tag)
        {
            // If it is an ENEMY
            // If the player does not have a weapon
            // Call the Damage function from the Enemy Script
            // Call the EnemyKilled function from the Enemy Script
            case "Enemy":
                if (!hasWeapon)
                {
                    enemy.Damage(10);       // Performs 10 damage
                }
                else
                {
                    enemy.EnemyKilled();    // Kills enemy
                }
                break;
            
            // If it is a MONEY object
            // Call the MoneyCollected funtion from the Money Script
            // Destroy the object after the function is finished running
            case "Money":
                money.MoneyCollected();
                Destroy(hit.gameObject);
                break;

            // If it is a Gem object
            // Call the GemCollected function from the Gem Script
            // Destroy the object after the function is finished running
            case "Gem":
                gem.GemCollected();
                Destroy(hit.gameObject);
                break;

            // If it is a Key object
            // Call th KeyCollected function from the Key Script
            case "Key":
                key.KeyCollected();
                break;

            // If it is a Door
            // If the player has the key
            // THEN print text and destroy object
            // OTHERWISE print text
            case "Door":
                if (key.hasKey)
                {
                    Debug.Log("You unlocked the door.");
                    Destroy(hit.gameObject);
                }
                else
                {
                    Debug.Log("You need a key to unlock this door.");
                }
                break;

            // If it is a Weapon object
            // Call the BuyingWeapon function from the Weapon Script
            case "Weapon":
                weapon.BuyingWeapon();
                break;

            //If it is a Health Pack
            // Call the ReplenishHealth function 
            // Destroy object
            case "Health_Pack":
                ReplenishHealth(100);       // Replenishes 100 health
                Destroy(hit.gameObject);
                break;

            // If the object is a Hazard
            // Print out text
            // Subtract 20 from the playerHealth variable
            // Print out how much health is remaining
            case "Hazards":
                Debug.Log("You have taken damage!");
                playerHealth -= 5;
                Debug.Log(string.Format("You have {0} left", playerHealth));
                break;
        }
    }

    // Respawn function to respawn the player when their health is below 0
    // Disables the player
    // THEN changes the position of the player to a given Vector3
    // Enables the player
    // Sets the playerHealth to 100
    public void Respawn()
    {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.GetComponent<Transform>().position = new Vector3(0f, 1.2f, -5f);
            gameObject.GetComponent<CharacterController>().enabled = true;
            playerHealth = 100;
    }

    // A function which replenishes the player's health
    // Prints out text
    // Adds the given amount to the variable playerHealth
    // Prints out how much health is remaining
    void ReplenishHealth(int amount)
    {
        Debug.Log("You used a Health Pack.");
        playerHealth += amount;
        Debug.Log(string.Format("You have {0} health.", playerHealth));
    }
}
