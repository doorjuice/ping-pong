using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteJoueur : MonoBehaviour
{
    public float sensitivity = 0.2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float deplacement = Input.GetAxis("Horizontal");
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(deplacement * sensitivity * Time.deltaTime, 0, 0, ForceMode.Force);

        var posi = transform.position;
        posi.x = Mathf.Clamp(posi.x, -1.5f, 1.5f);
        transform.position = posi;
    }
}
