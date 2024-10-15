using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEsfera : MonoBehaviour
{
    // ESTE SCRIPT ES UNA COPIA DEL EJERCICIO 12
    public float speed = 5f;
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Physics movement
    void FixedUpdate()
    {
        float step = speed * Time.fixedDeltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.AddForce(Vector3.forward * step);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_Rigidbody.AddForce(Vector3.back * step);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.AddForce(Vector3.left * step);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_Rigidbody.AddForce(Vector3.right * step);
        }
    }
}
