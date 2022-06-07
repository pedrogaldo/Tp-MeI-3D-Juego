using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionTest : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "test_collision")
        {
            SceneManager.LoadScene("ganaste_test");
        }

    }

}
