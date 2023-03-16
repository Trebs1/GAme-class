using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Rörelseminspelare : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private float motX;

    // Start is called before the first frame update
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
;   }

    // Update is called once per frame
    private void Update()
    {
        motX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(motX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 14f);
        }
        
        UpdateAnimationUpdate();
    }
    private void UpdateAnimationUpdate()
    {
        if (motX > 0f)
        {
            animator.SetBool("springer", true);
        }
        else if (motX < 0f)
        {
            animator.SetBool("springer", true);
        }
        else
        {
            animator.SetBool("springer", false);
        }
    }

}
