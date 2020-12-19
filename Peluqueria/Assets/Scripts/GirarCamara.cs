using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class GirarCamara : MonoBehaviour
{
    public float Speed;
    
    public void GirarDerecha()
    {
       
        transform.Rotate(0, Speed * Time.deltaTime, 0);
    }

    public void GirarIzquierda()
    {
        transform.Rotate(0, -Speed * Time.deltaTime, 0);
    }

}

