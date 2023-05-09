using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Rörelseminspelare : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D koll;
    private Animator animator;
    [SerializeField] private LayerMask Hoppmark;
    private SpriteRenderer sprite;
    private float motX = 0f;
    [SerializeField] private float springFart = 7f;
    [SerializeField] private float hoppkraft = 14f;
    private enum Rörelsedelar { rörelse, springa, hoppa, falla }
    [SerializeField] private AudioSource Hoppljudeffekt;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        koll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        ;
    }

    // Update is called once per frame
    private void Update()
    {
        motX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(motX * springFart, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && Landat())
        {
            rb.velocity = new Vector3(rb.velocity.x, hoppkraft);
            Hoppljudeffekt.Play();
        }

        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        Rörelsedelar state;

        if (motX > 0f)
        {
            state = Rörelsedelar.springa;
            sprite.flipX = false;
        }
        else if (motX < 0f)
        {
            state = Rörelsedelar.springa;
            sprite.flipX = true;

        }
        else
        {
            state = Rörelsedelar.rörelse;
        }

        if (rb.velocity.y > .1f)
        {
            state = Rörelsedelar.hoppa;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = Rörelsedelar.falla;
        }

        animator.SetInteger("state", (int)state);
    }

    private bool Landat()
    {
        return Physics2D.BoxCast(koll.bounds.center, koll.bounds.size, 0f, Vector2.down, .1f, Hoppmark);
    }
}

