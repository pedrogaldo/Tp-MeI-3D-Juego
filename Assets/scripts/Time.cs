using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour
{
    public GameObject timeDisplay;
    public int tiempoRestante;
    public bool restando = false;

    void Start()
    {
        timeDisplay.GetComponent<Text>().text = "00:" + tiempoRestante;
    }

    void Update()
    {
        if (restando == false && tiempoRestante > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (tiempoRestante == 0)
        {
            SceneManager.LoadScene("Perdiste");
        }
    }

    IEnumerator TimerTake()
    {
        restando = true;
        yield return new WaitForSeconds(1);
        tiempoRestante -= 1;
        timeDisplay.GetComponent<Text>().text = "00:" + tiempoRestante;
        restando = false;

    }
}
