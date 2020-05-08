using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBarra : MonoBehaviour
{
    private float ejeHorizontal = 0f;
    public float velocidadHorizontal = 1f;
    public float posicionMinimaX = -6f;
    public float posicionMaximaX = 6f;

    private void Update()
    {
        ejeHorizontal = Input.GetAxisRaw("Horizontal");

        if (ejeHorizontal != 0f)
        {
            Vector3 nuevoPosicion = transform.position;
            nuevoPosicion.x = nuevoPosicion.x + (velocidadHorizontal * ejeHorizontal * Time.deltaTime);
            nuevoPosicion.x = Mathf.Clamp(nuevoPosicion.x, posicionMinimaX, posicionMaximaX);
            transform.position = nuevoPosicion;
        }
    }
}