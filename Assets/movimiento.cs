using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
 
    public float speed;
    public float rotationSpeed;
    public float maxSpeed;
    public bool acceleration = true;
    

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
                speed += 0.01f;
            }

            else if (speed == maxSpeed)
            {
                transform.Translate(0, 0, speed);
            }
        }




        //desaceleracion del auto
        if (Input.GetKeyUp(KeyCode.W)&&speed>0)
        {
            acceleration = false;
        }

        if (acceleration == false&&speed>0)
        {
            speed -= 0.01f;
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
        if (Input.GetKey(KeyCode.S)&&speed>0)
        {
            speed -= 0.02f;
        }

       

    }

}
