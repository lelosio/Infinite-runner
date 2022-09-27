using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]

    public float JumpPower;
    public float movespeed;
    public bool isGrounded;
    public Vector3 direction;

    [SerializeField]
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
            }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += direction *movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += direction * -movespeed * Time.deltaTime;
        }
    }
}
