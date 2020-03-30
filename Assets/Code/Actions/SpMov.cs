using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @author: Olivverde (Oliver Josue de Leon Milian)
* Plataformas moviles y juegos
* Class's purpose:
* SpMov class allows the movement of an object
*/

public class SpMov : MonoBehaviour

{
    //Rigid Body
    Rigidbody rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate() {
        //Representation of the movement in "x" and "y" axis
        float Hmovement = Input.GetAxis("Horizontal");
        float Vmovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(Hmovement, 0, Vmovement);
        rb.AddForce(movement);

    }
}
