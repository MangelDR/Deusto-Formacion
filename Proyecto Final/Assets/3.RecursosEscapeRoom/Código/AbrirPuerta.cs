using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public Animator animatorPuerta;
    public GameObject player;
    public string mensajeAbrirPuerta = "La puerta está abierta, por fin podré volver a casa.";
    public string mensajeIntentarAbrirPuerta = "Esta puerta no tiene pomo... Tiene que haber alguna forma de abrirla.";
    public string mensajeLlave = "Necesito una llave para abrir la puerta";
    public ImprimirMensaje imprimirMensaje;
    public CargarEscenas managerEscenas;
    public GameObject pomo;

    private void OnMouseDown()
    {
        if (player.GetComponent<MovimientoPlayerNavigation>().key)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 2f && GetComponentInChildren<ColocarPomo>() == null)
            {
                imprimirMensaje.Imprimir(mensajeAbrirPuerta);
                animatorPuerta.SetTrigger("abrir");
                managerEscenas.VolverAlMenuRetraso(3f);
                pomo.SetActive(false);
                Destroy(this);
            }
            else
            {
                imprimirMensaje.Imprimir(mensajeIntentarAbrirPuerta);
            }
        }
        else
        {
            imprimirMensaje.Imprimir(mensajeLlave);
        }
    }
}
