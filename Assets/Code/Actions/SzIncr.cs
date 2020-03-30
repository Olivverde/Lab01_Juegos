using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @author: Olivverde (Oliver Josue de Leon Milian)
* Plataformas moviles y juegos
* Class's purpose:
* SzIncr class allows the increase of an object
*/

public class SzIncr : MonoBehaviour
{
    //Refers the increase of every axis
    float x;
    float y;
    float z;
    Vector3 Increaser;

    public void Update() {

        //Refers to the increase produced in every axis
        x += 0.10f*Time.deltaTime;
        y += 0.10f*Time.deltaTime;
        z += 0.10f*Time.deltaTime;

        //Instructions are executed via "x" and "z" buttons
        if(Input.GetKeyDown ("x")){
            transform.localScale += new Vector3(x,y,z);
        }else if (Input.GetKeyDown ("z")){
            transform.localScale += new Vector3(-x,-y,-z);
        }
    }
}
