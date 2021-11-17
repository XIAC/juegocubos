using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonMovimiento : MonoBehaviour
{
    private float velocidad = 1f;
    private Rigidbody rigiBody;
    public float valorFuerza;
    public float valorSalto;
    void Start()
    {
        rigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs( rigiBody.velocity.y) < 0.01f ) {
            Debug.Log("salto");
            // rigiBody.AddForce(Vector3.up * valorSalto, ForceMode.Impulse);
        }
   
    }
    void FixedUpdate()
    {
        rigiBody.AddForce(new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * valorFuerza));
    }
}
