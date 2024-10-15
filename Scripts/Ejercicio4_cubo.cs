using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_cubo : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * speed);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * speed);
        } 
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * speed);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * speed);
        } 
    }
}
