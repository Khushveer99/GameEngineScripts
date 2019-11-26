using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // A function which allows the player to collect money
    // Adds 100 to the moneyCounter from the Player Script
    // Prints how much money is remaining
    public void MoneyCollected()
    {
        Debug.Log("You collected money!");
        FindObjectOfType<Player>().moneyCounter += 100;
        Debug.Log(string.Format("Money: {0}", FindObjectOfType<Player>().moneyCounter));
        //Destroy(gameObject);
    }

}
