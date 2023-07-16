using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FrutManaguer : MonoBehaviour
{
    public TMP_Text levedCleared;

    private void Update()
    {
        Allkiwi();
    }
    /// <summary>
    /// The function "Allkiwi" checks if there are no more child objects under the current transform,
    /// and if so, it logs a message, activates a game object, and changes the scene after a delay.
    /// </summary>
    public void Allkiwi()
    {
        if(transform.childCount ==0)

        {
            Debug.Log("No quedan frutas,victoria");
            levedCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
    