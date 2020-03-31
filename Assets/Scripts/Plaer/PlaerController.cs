using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController : MonoBehaviour
{

    public GameObject MainCamera;

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpForce = 1.0f;


    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {

        if (Input.GetButton("Horizontal")) MoveX();
        if (Input.GetButton("Vertical")) MoveY();
        if (Input.GetButtonDown("Jump")) Jump();
        
    }

    private void MoveX()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }
    private void MoveY()
    {
        Vector3 direction = transform.forward * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position , transform.position + direction, speed * Time.deltaTime);
    }

    private void Jump()
    {
       rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}


