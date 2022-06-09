using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y==-1)
        {
            SceneManager.LoadScene("Perdiste");
        }
    }
}
