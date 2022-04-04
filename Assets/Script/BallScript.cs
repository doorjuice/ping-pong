using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Vector3 InitialPosition = new Vector3(0, 1, 1.5f);
    public Vector3 InitialVelocity = new Vector3(0, 0, -1.5f);

    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = InitialVelocity;
        transform.position = InitialPosition;
    }

    private void Update()
    {
        if (Input.GetKeyUp("r"))
        {
            transform.position = InitialPosition;
            rigidBody.velocity = InitialVelocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision with {collision.transform.name}");
    }
}
