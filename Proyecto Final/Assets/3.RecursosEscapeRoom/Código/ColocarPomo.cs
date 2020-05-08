using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarPomo : MonoBehaviour
{
    public Transform player;
    public string mensajeCogerPomo = "El pomo de la puerta estaba en el suelo, sera mejor que lo ponga en su lugar.";
    public ImprimirMensaje imprimirMensaje;

    private void OnMouseDown()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 2f)
        {
            imprimirMensaje.Imprimir(mensajeCogerPomo);
            transform.localPosition = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;
            Destroy(this);
        }
    }
}
