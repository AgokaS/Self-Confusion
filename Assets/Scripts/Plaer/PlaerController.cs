using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //rb.AddForce(movement * speed);


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


