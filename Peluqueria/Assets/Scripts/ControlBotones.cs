using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlBotones : MonoBehaviour
{
    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Estilos()
    {
        SceneManager.LoadScene("Estilos");
    }


}
