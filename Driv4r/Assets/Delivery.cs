using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;
    [SerializeField] float delayForDestroy = 0.5f;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage) 
        {
            hasPackage = true;
            Debug.Log("Package picked up.");
            Destroy(other.gameObject, delayForDestroy);
        }
        else if (other.tag == "Customer" && hasPackage == true)
        {
            hasPackage = false;
            Debug.Log("Package delivered.");
        }
    }
}
