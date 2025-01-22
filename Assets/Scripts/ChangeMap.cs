using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMap : MonoBehaviour
{
    private bool Overworld = true;
    public GameObject player;


    private void Start()
    {
       
    }

    public void change()

    {

        if ((player.transform.position - transform.position).magnitude < 3.5)
        {
            if (Overworld == true)
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


    private void OnEnable()
    {
        Actions.interact += change;
    }
    private void OnDisable()
    {
        Actions.interact -= change;
    }

}
