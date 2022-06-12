    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour
{
 
    public float speed;
    public float rotationSpeed;
    public float maxSpeed;


    public bool acceleration = true;
    public bool reverse = false;



    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        //aceleracion del auto

        transform.Translate(0, 0, speed);



        if (Input.GetKey(KeyCode.W))
        {
            acceleration = true;

            if (speed <= maxSpeed)
            {
                speed += 0.005f;
            }

            else if (speed == maxSpeed)
            {
                transform.Translate(0, 0, speed);
            }
        }



        //aceleracion en reversa


        if (reverse == true)
        {
            if (speed <= 0)
            {
                speed -= 0.005f;
            }
        }


        //desaceleracion en reversa

        if (Input.GetKeyUp(KeyCode.S) && speed <= 0)
        {
            reverse = false;
        }

        if (reverse == false && speed <= 0)
        {
            speed += 0.005f;
        }

        //desaceleracion del auto
        if (Input.GetKeyUp(KeyCode.W)&&speed>0)
        {
            acceleration = false;
        }

        if (acceleration == false&&speed>0)
        {
            speed -= 0.005f;
        }
        
               

        //viraje del auto


        
        if (speed > 0)
        {

             if (Input.GetKey(KeyCode.A))
             {
                transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
             }


             if (Input.GetKey(KeyCode.D))
             {
                transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
             }

         }

        



        //frenos 
        if (Input.GetKey(KeyCode.S)&&speed>=-1.421f)
        {
            reverse = true;
            speed -= 0.01f;
        }



        //reiniciar
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Juego");
        }

       

    }

}
