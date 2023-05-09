using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spelarensliv : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource d�dsljudeffekt;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("F�llor"))
        {
            D�();
        }
    }

    private void D�()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("D�d");
        d�dsljudeffekt.Play();
    }

    private void StartaOmLeveln()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
