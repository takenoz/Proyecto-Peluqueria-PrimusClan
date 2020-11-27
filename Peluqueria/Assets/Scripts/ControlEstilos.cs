using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEstilos : MonoBehaviour
{
    public GameObject EstiloHombre;
    public GameObject EstiloMujer;

    public void ActivarHombre()
    {
        EstiloHombre.SetActive(true);
        EstiloMujer.SetActive(false);
    }

    public void ActivarMujer()
    {
        EstiloMujer.SetActive(true);
        EstiloHombre.SetActive(false);
    }

}
