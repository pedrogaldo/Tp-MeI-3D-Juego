using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour
{

    public bool checkpoint = false;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "checkpoint")
        {
            checkpoint = true;
        }

        if (checkpoint == true && col.gameObject.name == "meta")
        {
            SceneManager.LoadScene("Ganaste");
        }

    }
}
