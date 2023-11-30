using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
        
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); )
        }  
}          
