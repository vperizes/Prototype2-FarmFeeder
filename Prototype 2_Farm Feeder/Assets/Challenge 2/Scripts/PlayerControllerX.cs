using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0; //setting initial condition to 0 so player can spawn dog immediately on play 

    // Update is called once per frame
    void Update()
    {
        // Creating a chain of multiple conditions that need to be satisified to spawn dag. Player hits space bar and cool down must be less than or equal to zero
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1; //cool down is set to 1 sec after a dog is spawned
        }

        
        //cool down is set to 1 after spawn and will decrease every frame with time until it is zero. 
        //"if" statment makes sure that cool down applies to positive numbers
        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
        
    }
}
