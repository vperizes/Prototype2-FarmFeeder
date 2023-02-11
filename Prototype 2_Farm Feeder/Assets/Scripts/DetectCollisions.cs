using System.Collections;
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

        gameObject.SetActive(false); //sets projectile in pool to false

        if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(1);
            Destroy(other.gameObject); //destroys animal
        }


        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);

        }

    }

}
