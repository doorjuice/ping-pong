using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetteJoueur : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float deplacement = Input.GetAxis("Horizontal");
        transform.Translate(0, 0, deplacement * 0.1f * Time.deltaTime);

        var posi = transform.position;
        posi.x = Mathf.Clamp(posi.x, -1.5f, 1.5f);
        transform.position = posi;

    }


}
