using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject ballPosition;

    static public bool ballExistFlag = false;

    public float accel = 1000.0f;
    
    Rigidbody rb;
  

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * Input.GetAxis("Horizontal") * accel,ForceMode.Impulse);

        if (Input.GetKeyDown("space"))
        {
            if(ballExistFlag == false)
            {
                Instantiate(ball,
                        ballPosition.transform.position,
                        ballPosition.transform.rotation);
                ballExistFlag = true;

            }
            
        }

    }
}
