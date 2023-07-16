using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{
    public static bool isGrounde;

    private void OnTriguerEnter2D(Collider2D collision)
    {
        isGrounde = true;
    }

    /// <summary>
    /// The function is called when another collider exits the trigger area in a 2D environment.
    /// </summary>
    /// <param name="Collider2D">The Collider2D parameter represents the collider component attached to
    /// the game object that triggered the exit event. It is a reference to the collider that the other
    /// collider exited from.</param>
    private void OnTriguerExit2D(Collider2D other)
    {
        isGrounde = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
