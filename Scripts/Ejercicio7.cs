using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public float speed;
    Vector3 direccion_esfera;
    
    GameObject esfera; 
    // Start is called before the first frame update
    void Start()
    {
        esfera =  GameObject.FindWithTag("sphere");
    }

    // Update is called once per frame
    void Update()
    {
        // pos. destino - pos. origen = vector movimiento
        direccion_esfera = esfera.transform.position - transform.position; 
        transform.Translate(direccion_esfera.normalized * speed * Time.deltaTime, Space.World);
        // Ejercicio7
        transform.LookAt(esfera.transform);
    }
}
