using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20.0f;
    private float xRange = 20;
    private float zRange = 5;
    private float zRangeLow = -1.0f;
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        // Check for horizontal (left and right) bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if(transform.position.z < zRangeLow)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeLow);
        }

        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        
        //Player movement forward and back
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            ///No longer necessary to Instantiate prefabs
            ///Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);


            //Get an object object from the pool
            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it
                pooledProjectile.transform.position = transform.position; // position it at player
            }
        }

    }


}
