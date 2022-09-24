using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package") 
        {
            hasPackage = true;
            Debug.Log("Package picked up.");
        }
        else if (other.tag == "Customer" && hasPackage == true)
        {
            hasPackage = false;
            Debug.Log("Package delivered.");
        }
    }
}
