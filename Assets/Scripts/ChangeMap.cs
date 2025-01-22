using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMap : MonoBehaviour
{
    private bool Overworld;
    private void Start()
    {
        Overworld = true;
    }

    public void change()

    {
     if (Overworld = true)
        {
            SceneManager.LoadScene("Underworld");
                Overworld = false;
        }
     else
        {
            SceneManager.LoadScene("Above Ground");
                Overworld = true;
        }
    }
}
