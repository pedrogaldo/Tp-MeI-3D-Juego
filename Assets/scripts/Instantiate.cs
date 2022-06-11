using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiate : MonoBehaviour
{
    public GameObject objeto;
    int tiempo = 5;
    bool instant = false;

    void instantiateObject()
    {
        while (tiempo > 0)
        {
            instant = false;
            Instantiate(objeto);
            tiempo--;
            
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        

     
    }
}
