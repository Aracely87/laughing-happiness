using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    bool muevePelota;
    public static bool ahllegado;
    public static bool dasClick;
    
    // Start is called before the first frame update
    void Start()
    {
        muevePelota = false;
        ahllegado = false;
        dasClick = false;
    }
    private void OnMouseDown()
    {
        muevePelota = true;
        dasClick = true;
        //transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 1.5f *Time.deltaTime);
    }
    // Update is called  once per frame
    /// <summary>
    /// The Update function moves and scales an object towards the origin until it reaches it.
    /// </summary>
    void Update()
    {
        if (muevePelota== true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 7.7f * Time.deltaTime);
            transform.localScale = Vector3.MoveTowards(transform.localScale, transform.localScale / 3, 0.7f * Time.deltaTime);
            if (transform.position== Vector3.zero)
            {
                ahllegado = true;
                muevePelota = false;
            }
        }
    }
}
