using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float accelerate = 10f;
    [SerializeField] float turnSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float accelerateAmount = Input.GetAxis("Vertical") * accelerate * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, accelerateAmount, 0);
    }
}
