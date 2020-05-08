using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerradura : MonoBehaviour
{
    public Animator animatorPuerta;
    public GameObject TeletransporteEntrada;
    public GameObject TeletransporteSalida;

    private void OnTriggerEnter(Collider other)
    {
        if (RecogerLlave.llaveRecogida)
        {
            animatorPuerta.SetTrigger("abrir");
            Debug.Log("Abrir Puerta");
            TeletransporteEntrada.SetActive(true);
            TeletransporteSalida.SetActive(true);

        }
        else
        {
            Debug.Log("Debes recoger la llave");
        }
    }
}
