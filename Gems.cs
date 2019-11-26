using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{

    public int gemCounter;

    public GameObject particle;                     // Asigning GameObject of particle system to variable particle

    // Start is called before the first frame update
    void Start()
    {
        particle = GameObject.Find("Particle_System");      // Grabs the Particle System object and assign it to the Particle variable
    }

    //Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);     // Rotates the object by a given Vector3
    }

    // A function which collects Gems
    // Prints text
    // Adds 1 to the gemCounter
    // Prints how many Gems the player has
    // Destroys Particle
    public void GemCollected()
    {
        Debug.Log("You collected a Gem!");
        gemCounter++;
        Debug.Log(string.Format("Gems: {0}", gemCounter));
        Destroy(particle);
        //Destroy(gameObject);

    }

}
