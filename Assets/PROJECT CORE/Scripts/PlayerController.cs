using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerspeed;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        
    }

 
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerspeed * Time.fixedDeltaTime);
    }
}
