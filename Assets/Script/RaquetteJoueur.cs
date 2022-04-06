using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteJoueur : MonoBehaviour
{
    public float sensitivity = 0.2f;

    //private float mousePosX = Input.mousePosition.x;

    // Update is called once per frame
    void FixedUpdate()
    {
        //var deplacement = Input.mousePosition.x - mousePosX;
        //mousePosX = Input.mousePosition.x;
        //Debug.Log(deplacement);

        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.AddForce(deplacement * sensitivity, 0, 0, ForceMode.Force);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            Debug.Log(hit.point);

    }
}
