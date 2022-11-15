using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int i;
    private int ii;

    public float jumpForce;
    public float moveSpeed;
    public float forwardSpeed;
    public Rigidbody rb;
    public LayerMask groundMask;
    private float distToGround;

    private bool isGrounded;

    void Start()
    {
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            transform.position = Vector3.zero;
            i = 0;
        }
    }
    
    public void FixedUpdate()
    {
        transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
        Debug.Log(isGrounded);
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);

        if (isGrounded)
        {
            ii = 0;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            if (ii != 2)
            {
                ii++;
                rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (i == 0 || i == 1)
            {
                --i;
                transform.position += Vector3.left * moveSpeed;

            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (i == 0 || i == -1)
            {
                ++i;
                transform.position += Vector3.right * moveSpeed;
            }
        }
    }


}