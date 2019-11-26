using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Player player;              // Assigning Player script to variable player


    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // A function which damages the player when they come in contact with an Enemy (without a weapon)
    // Prints how much damage is remaining
    public void Damage(int playerDamage)
    {
        player.playerHealth -= playerDamage;
        Debug.Log(string.Format("Taken {0} damage!", playerDamage));
        Debug.Log(string.Format("You have {0} Health left.", player.playerHealth));

        // If the player's health is less than and equal to 0
        // Call the Respawn function from the Player Script
        if (player.playerHealth <= 0)
        {
            player.Respawn();
        }
    }

    // A function to kill the Enemy
    // Destory object and print text
    public void EnemyKilled()
    {
        Destroy(gameObject);
        Debug.Log("Enemy killed!");
    }
}
