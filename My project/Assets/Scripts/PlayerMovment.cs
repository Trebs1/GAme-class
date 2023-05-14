using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField]private float MovmentSpeed = 2f;
    private Vector2 PlayerDiraction;
    [SerializeField]private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float DirectionX = Input.GetAxisRaw("Horizontal");
        float DirectionY = Input.GetAxisRaw("Vertical");

        PlayerDiraction = new Vector2(DirectionX, DirectionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(PlayerDiraction.x * MovmentSpeed, PlayerDiraction.y * MovmentSpeed);
    }
}