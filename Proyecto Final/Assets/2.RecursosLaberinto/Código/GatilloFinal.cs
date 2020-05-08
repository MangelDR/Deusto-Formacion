using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilloFinal : MonoBehaviour
{
    public CargarEscenas managerEscenas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) managerEscenas.MetodoCargarEscena(0);
    }
}
