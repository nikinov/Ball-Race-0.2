using System.Collections;
using System.Collections.Generic;
using Ditzelgames;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    public float forwardForce;
    public float SideSpeed;

    float Horizontal;
    float Vertical;

    float Chek;
    public GameObject DethUI;
    public GameObject CompUI;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Awake()
    {
        //rb.velocity = transform.forward * Time.deltaTime * speed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        PhysicsHelper.ApplyForceToReachVelocity(rb, Vector3.forward * forwardForce * Time.deltaTime, forwardSpeed * Time.deltaTime);

        //rb.AddTorque(Vector3.forward * speed);

        if (DethUI == true)
        {
            Chek = 0;
        }
        if (CompUI == true)
        {
            Chek = 0;
        }
        else
        {
            Chek = 1;
        }
        //rb.MovePosition(transform.position + (transform.forward * Time.deltaTime));

        //transform.position += transform.forward * Time.deltaTime * forwardForce;

        //rb.velocity = transform.forward * Time.deltaTime * forwardForce;

        //transform.Rotate(forwardForce * Time.deltaTime, 0, 0);

        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0.0f, 0.0f, Vertical);
        Vector3 Sidemove = new Vector3(Horizontal, 0.0f, 0.0f);

        rb.AddForce(move * speed * Time.deltaTime);
        rb.AddForce(Sidemove * SideSpeed * Time.deltaTime);
    }
    public void Die ()
    {
        speed = 0;
        forwardForce = 0;
        SideSpeed = 0;
    }
    public void GoLeft ()
    {
        Horizontal += -10000;
    }
    public void GoRight ()
    {
        Horizontal += 10000;
    }
    public void Forward ()
    {
        Vertical += 10000;
    }
    public void Back ()
    {
        Vertical += -10000;
    }
}
