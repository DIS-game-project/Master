﻿using UnityEngine;
using System.Collections;

public class BrickSmallest : MonoBehaviour
{

   
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
        //don't play audio for small damages
        if (damage >= 10)
            GetComponent<AudioSource>().Play();
        //decrease health according to magnitude of the object that hit us
        Health -= damage;
        //if health is 0, destroy the block
        if (Health <= 0)
        {
            
            Destroy(gameObject);
            //Instantiate(Remains, transform.position, transform.rotation);
            //This will create a copy of the remains at the exact position of the brick. Afterwards, the object will be removed, giving the illusion that the new one is actually the old one, but "broken".
        }
    
    }
    //public GameObject Remains;
    public float Health = 70f;


    //wood sound found in 
    //https://www.freesound.org/people/Srehpog/sounds/31623/
}
