using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// La esfera gira con el eje horizontal y solo se puede mover libremente por el eje vertical
public class Ejercicio8 : MonoBehaviour
{
    public float move_speed;
    public float rotate_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward);

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(transform.forward * move_speed * Time.deltaTime, Space.World);
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(-transform.forward * move_speed * Time.deltaTime, Space.World);
        } 
        
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(-Vector3.up * rotate_speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up* rotate_speed * Time.deltaTime);
        } 
    }
}
