using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeInicio : MonoBehaviour
{
    public void scene_change_inicio()
    {
        SceneManager.LoadScene("Pantalla_De_Inicio");
    }
}
