using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_cubo : MonoBehaviour
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
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        } 
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        } 
    }
}
