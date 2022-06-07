using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeJuego : MonoBehaviour
{
    public void scene_change_juego()
    {
        SceneManager.LoadScene("Juego");
    }
}
