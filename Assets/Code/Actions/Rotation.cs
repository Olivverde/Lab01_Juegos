using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @author: Olivverde (Oliver Josue de Leon Milian)
* Plataformas moviles y juegos
* Class's purpose:
* Rotation class allows the rotation of an object
*/

public class Rotation : MonoBehaviour
{
    //Refers to the rotation angle
    public float rotAngle = 90;
    
    // Update is called once per frame
    void Update()
    {
        //Rotates in the "y" axis, using the time as part of the function
        transform.Rotate(new Vector3(0,0,rotAngle)*Time.deltaTime);
    }
}
