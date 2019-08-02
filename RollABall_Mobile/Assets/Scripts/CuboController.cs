using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboController : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 v;
    void Update()
    {
        v = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        v *= speed;
        transform.Translate(v);
    }
}
