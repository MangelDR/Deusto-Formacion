using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayerNavigation : MonoBehaviour
{
    private Ray rayo;
    private RaycastHit golpeo;
    private Vector3 destino;
    public bool key = false;
    public Animator animator;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayo,out golpeo))
            {
                destino = golpeo.point;
                GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(destino);
              

            }
        }
    }
}
