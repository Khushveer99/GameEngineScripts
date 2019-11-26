using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);     // Rotates object by a given Vector3
    }

    // A function which collects Keys
    // Sets hasKey boolean to TRUE
    // Prints text
    // Destroy object
    public void KeyCollected()
    {
        hasKey = true;
        Debug.Log("Key collected! You can now go through the outside doors.");
        Destroy(gameObject);
    }

}
