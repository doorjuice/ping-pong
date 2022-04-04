using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteJoueur : MonoBehaviour
{
    public float sensitivity = 0.2f;

    // Update is called once per frame
    void Update()
    {
        float deplacement = Input.GetAxis("Horizontal");
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(deplacement * sensitivity * Time.deltaTime, 0, 0, ForceMode.Impulse);
        //transform.Translate(deplacement * 0.1f * Time.deltaTime, 0, 0);



        var posi = transform.position;
        posi.x = Mathf.Clamp(posi.x, -1.5f, 1.5f);
        transform.position = posi;

    }


}
