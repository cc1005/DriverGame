using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float accelerate = 10f;
    [SerializeField] float turnSpeed = 200f;
    [SerializeField] float slowSpeed = -2f;
    [SerializeField] float boostSpeed = 5f;

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

   private void OnTriggerEnter2D(Collider2D other) 
   {
    if (other.tag == "Boost" && accelerate < 50)
    {
        accelerate += boostSpeed;
        Destroy(other.gameObject);
    }
   }

   private void OnCollisionEnter2D(Collision2D other) {
    if ((other.gameObject.tag != "Boost" || other.gameObject.tag != "Package" || other.gameObject.tag != "Customer") && accelerate > 5)
    {
        accelerate += slowSpeed;
    }
   }

}
