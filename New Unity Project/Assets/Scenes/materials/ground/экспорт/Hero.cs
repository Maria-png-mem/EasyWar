using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hero : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
   
    public bool faceRight = true;

    private Animator anim;
    public float Jumpforce;
    private bool isGround;
    public Transform groundCheak;
    private int ExtraJump;
    public int extraJumpValue;
    public float cheakRadius;
    public LayerMask WhatIsGround;
    [SerializeField]  GameObject itogi;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (isGround) State = States.idle;

        if (!isGround) State = States.jump;
        if (isGround == true)
        {
            ExtraJump = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && ExtraJump > 0)
        {
            rb.velocity = Vector2.up * Jumpforce;
            ExtraJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && ExtraJump == 0 && isGround == true)
        {
            rb.velocity = Vector2.up * Jumpforce;
        }
    }

    

    private void FixedUpdate()

    {
       
        isGround = Physics2D.OverlapCircle(groundCheak.position, cheakRadius, WhatIsGround);

        if (isGround) State = States.idle;
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (faceRight == false && moveInput > 0)
        {
            Flip();
        }

        if (faceRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        faceRight = !faceRight;
        transform.Rotate(0f, 180f, 0f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            itogi.SetActive(true);
            Time.timeScale = 0;
        }

    }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }
}
public enum States
{
    run,
    idle,
    jump,
    climb
}