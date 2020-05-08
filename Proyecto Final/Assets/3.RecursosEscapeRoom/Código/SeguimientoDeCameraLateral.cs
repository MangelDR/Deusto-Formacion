using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoDeCameraLateral : MonoBehaviour
{
    public Transform target;
    public Vector3 compensacion = new Vector3(0f, 4f, -4f);
    public float minimoX = -2f;
    public float maximoX = 2f;

    private Vector3 posicionNueva;

    private void Update()
    {
        posicionNueva = target.transform.position + compensacion;

        posicionNueva.x = Mathf.Clamp(posicionNueva.x, minimoX, maximoX);

        transform.position = posicionNueva;
        transform.LookAt(target);
    }
}
