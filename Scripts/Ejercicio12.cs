using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    private GameObject esfera;    
    public float speed = 5f;       

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        esfera =  GameObject.FindWithTag("sphere");
    }

    // Physics movement
    void FixedUpdate()
    {
        float step = speed * Time.fixedDeltaTime;
        
        Vector3 newPosition = Vector3.MoveTowards(transform.position, esfera.transform.position, step);
        rb.MovePosition(newPosition);

        if (Input.GetKey(KeyCode.U)) {
            transform.Translate(Vector3.forward * step);
        } else if (Input.GetKey(KeyCode.J)) {
            transform.Translate(Vector3.back * step);
        } 
        
        if (Input.GetKey(KeyCode.H)) {
            transform.Translate(Vector3.left * step);
        } else if (Input.GetKey(KeyCode.K)) {
            transform.Translate(Vector3.right * step);
        }
    }
}
