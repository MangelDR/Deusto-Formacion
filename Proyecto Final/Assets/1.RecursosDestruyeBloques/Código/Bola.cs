using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public Vector2 velocidadInicio = Vector2.zero;
    public ManagerPuntuacion managerPuntuacion;

    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().AddForce(velocidadInicio, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bloque"))
        {
            managerPuntuacion.SumarPuntos(col.gameObject.GetComponent<Bloque>().puntosPorBloque);
            col.gameObject.SetActive(false);

            if (FindObjectsOfType<Bloque>().Length <= 0)
            {
                managerPuntuacion.Victoria();
                GetComponent<Rigidbody2D>().Sleep();
            }
        }
    }

    private void OnDisable()
    {
        GetComponent<Rigidbody2D>().Sleep();
    }
}