using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rigBod;

    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Called before rendering a frame 
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// Called before performing any physics calculations 
    /// </summary>
    void FixedUpdate()
    {
        float moveHort = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHort, 0.0f, moveVert);

        rigBod.AddForce(movement * speed);
    }
}
