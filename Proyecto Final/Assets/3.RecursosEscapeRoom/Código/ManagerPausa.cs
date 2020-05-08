using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPausa : MonoBehaviour
{
    private bool juegoPausado = false;
    public GameObject canvasPausa;
    public CargarEscenas managerEscenas;

    private void Update()
    {
        if (juegoPausado)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                managerEscenas.MetodoCargarEscena(0);
            }
            else if (Input.anyKeyDown)
            {
                canvasPausa.SetActive(false);
                juegoPausado = false;
            }
        }
        else
        {
            if (Input.GetButtonDown("Cancel"))
            {
                canvasPausa.SetActive(true);
                juegoPausado = true;
            }
        }
    }
}
