using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInterfaz : MonoBehaviour
{
    public Text mensajePantalla;

    public void CambiarMensaje(string mensaje)
    {
        mensajePantalla.text = mensaje;
    }
}
