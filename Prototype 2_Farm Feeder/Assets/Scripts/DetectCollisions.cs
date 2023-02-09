﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }



    void OnTriggerEnter(Collider other)
    {
        /// Instead of destroying the projectile when it collides with an animal
        /// Destroy(other.gameObject);
        /// Just deactivate the food and destroy the animal

        other.gameObject.SetActive(false);
        Destroy(gameObject);
        GameManager.score++;

        if (other.gameObject.tag == "Player")
        {
            gameManager.AddLives(-1);
            
        }
       
    }

}
