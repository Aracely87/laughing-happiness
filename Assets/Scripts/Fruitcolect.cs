using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitcolect : MonoBehaviour
{
     /// <summary>
     /// This function is triggered when a 2D collider enters another collider, and if the entering
     /// collider has the tag "Player", it disables the sprite renderer of the current object, activates
     /// the first child object, and destroys the current object after 0.5 seconds.
     /// </summary>
     /// <param name="Collider2D">The Collider2D parameter is the collider component attached to the
     /// game object that this script is attached to. It is used to detect collisions with other
     /// colliders in the scene.......</param>
     private void OnTriguerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
        }
    }
}
