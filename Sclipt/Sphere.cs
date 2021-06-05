using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    [SerializeField]
    private float speed = 30.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.right+transform.forward)*speed,ForceMode.VelocityChange);

    }

    // Update is called once per frame
    
}
