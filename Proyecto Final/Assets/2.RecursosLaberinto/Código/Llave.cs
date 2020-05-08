using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public string mensaje = "Encuentra la salida secreta";
    public ManagerInterfaz managerInterfaz;
    public GameObject llavePadre;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RecogerLlave.llaveRecogida = true;
            managerInterfaz.CambiarMensaje(mensaje);
            llavePadre.SetActive(false);
        }

    }
}
