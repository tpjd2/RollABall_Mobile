using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private float movimentoX;
    private float movimentoY;
    private Vector3 forca;
    private Vector3 movimento;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forca = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //movimentoX = Input.GetAxis("Horizontal");
        //movimentoY = Input.GetAxis("Vertical");

        movimento = Input.acceleration;

        forca.x = movimento.x;
        forca.z = movimento.y;
        forca *= speed;
        rb.AddForce(forca);
    }
}
