using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float xBound = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            ///Instead of destroying the projectile when it leaves the screen
            ///Destroy(gameObject); Just deactivate it

            gameObject.SetActive(false);

        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > xBound || transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        

    }
}
