using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float Force;
    private Vector3 md;
    public float gs;
    public CharacterController controller;
    void Start()
    {
         controller = GetComponent<CharacterController>();
    } 
    // Update is called once per frame
    void Update()
    {
       // rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Speed, rb.velocity.y, Input.GetAxis("Vertical") * Speed);
        //if(Input.GetButtonDown("Jump"))
//rb.velocity = new Vector3(rb.velocity.x, Force, rb.velocity.z);     
        md = new Vector3(Input.GetAxis("Horizontal") * Speed, md.y, Input.GetAxis("Vertical") * Speed);
        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("Goo");
                md.y = Force;
            }
        }
        md.y = md.y +(Physics.gravity.y * gs * Time.deltaTime);
        controller.Move(md * Time.deltaTime);
    }
}
