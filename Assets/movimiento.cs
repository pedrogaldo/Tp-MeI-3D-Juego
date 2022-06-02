using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
 
    public float speed;
    public float rotationSpeed;
    public float maxSpeed;
    public float acceleration;
    

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            //aceleracion del auto
            if (speed < maxSpeed)
            {
                transform.Translate(0, 0, speed);
                speed += 0.01f;
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
