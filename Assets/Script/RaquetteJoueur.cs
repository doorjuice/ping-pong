using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteJoueur : MonoBehaviour
{
    public float sensitivity = 0.01f;

    private float mousePosX;

    private void Awake()
    {
        mousePosX = Input.mousePosition.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null && rb.isKinematic)
            KinematicControl();
        else
            PhysicsControl();
    }

    void KinematicControl()
    {
        var deplacementX = Input.mousePosition.x - mousePosX;
        mousePosX = Input.mousePosition.x;
        transform.Translate(deplacementX * sensitivity, 0, 0, Space.World);
    }

    void PhysicsControl()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.AddForce(deplacement * sensitivity, 0, 0, ForceMode.Force);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.collider.name); //Display the name of the collider hit
            //Debug.Log(hit.point);
            transform.position = hit.point;
        }
    }
}
