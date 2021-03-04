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
    private float temps;
    public CharacterController controller;
    public Animator anim;
    public GameObject player;
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
        if (Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("d"))
        {   
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if (controller.isGrounded)
        {
            anim.SetBool("isFalling", false);
            anim.SetBool("isJumping", false);
            Debug.Log(controller.isGrounded);
            md.y = 0;
            temps = 0;
            if (Input.GetButtonDown("Jump"))
            {
                anim.SetBool("isJumping", true);
                md.y = Force;
            }
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Falling Flat Impact") || anim.GetCurrentAnimatorStateInfo(0).IsName("Getting Up"))
        {
            controller.enabled = false;
        }
        else 
        {
            controller.enabled = true;
        }
        md.y = md.y +(Physics.gravity.y * gs * Time.deltaTime);
        controller.Move(md * Time.deltaTime);
        
    }
    void FixedUpdate()
    {
        if (!controller.isGrounded)
        {
        
            temps = temps + 10;
            if (temps >= 750)
                anim.SetBool("isFalling", true);
 
            if (temps >= 1500)
                {
                    transform.position = new Vector3(0f,30f,0f);
                    md.y =0;
                    temps = 0;
                }
        }
    }
}
