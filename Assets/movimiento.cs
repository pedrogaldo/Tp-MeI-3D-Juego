using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            for(speed=0; speed<0.01; speed+=0.0001f)
            {
                transform.Translate(0, 0, speed);
            }
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            while (speed > 0)
            {
                speed -= 0.0001f;
            }
        }

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


        if (speed == 0)
        {
            if (Input.GetKey(KeyCode.S))
            { 
                transform.Translate(0, 0, -speed);
            }
        }
           

    }
}
