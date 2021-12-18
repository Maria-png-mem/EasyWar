using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfF : MonoBehaviour
{
    private float speed = 0.9f;
    private Vector3 dir;
    private SpriteRenderer sprite;
    public int collisionDamage = 2;
    public string collisionTag;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        dir = transform.right;

    }


    void Update()
    {
        Move();


    }


    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);

        if (colliders.Length > 0) dir *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }




}