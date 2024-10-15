using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{   
    public double speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Flecha Arriba " + speed * Input.GetAxis("Fire"));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Flecha Abajo " + speed * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Flecha Izquierda " + speed * Input.GetAxis("Horizontal"));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Flecha Derecha " + speed * Input.GetAxis("Horizontal"));
        } 
    }
}
