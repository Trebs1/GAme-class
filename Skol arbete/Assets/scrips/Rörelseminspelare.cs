using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Rörelseminspelare : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sprite;
    private float motX = 0f;
    [SerializeField]private float springFart = 7f;
    [SerializeField]private float hoppkraft = 14f;
    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

;   }

    // Update is called once per frame
    private void Update()
    {
        motX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(motX * springFart, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, hoppkraft);
        }
        
        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        if (motX > 0f)
        {
            animator.SetBool("springer", true);
            sprite.flipX = false;
        }
        else if (motX < 0f)
        {
            animator.SetBool("springer", true);
            sprite.flipX=true;
            
        }
        else
        {
            animator.SetBool("springer", false);
        }
    }

}
