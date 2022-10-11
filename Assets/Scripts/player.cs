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

    private Vector3 normalizeDirection;

    public Transform target;
    public float speed = 1f;

    [SerializeField]
    private Rigidbody rb;

    bool isAlive = true;


    // Start is called before the first frame update
    void Start()
    {

       normalizeDirection = (target.position - transform.position).normalized;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            isAlive = false;
            Debug.Log(collision.collider.name);

        }
    }

    // Update is called once per frame
    public void Update()
    {
        if(isAlive)
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



            transform.position += Vector3.forward * speed * Time.deltaTime;

        }

    }


}