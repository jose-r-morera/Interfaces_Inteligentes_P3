using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Movimiento respecto al sistema local
        transform.Translate(moveDirection * Time.deltaTime * speed);

        // Movimiento respecto al eje global
        // transform.Translate(moveDirection * Time.deltaTime * speed, Space.World);
    }
}
