using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    private GameObject esfera;    
    public float follow_speed = 5f;
    public float move_speed = 30f;

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
        float follow_step = follow_speed * Time.fixedDeltaTime;
        float move_step = move_speed * Time.fixedDeltaTime;
        
        Vector3 newPosition = Vector3.MoveTowards(transform.position, esfera.transform.position, follow_step);
        rb.MovePosition(newPosition);

        if (Input.GetKey(KeyCode.U))
        {
            rb.AddForce(Vector3.forward * move_step);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector3.back * move_step);
        }

        if (Input.GetKey(KeyCode.H))
        {
            rb.AddForce(Vector3.left * move_step);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.right * move_step);
        }
    }
}
