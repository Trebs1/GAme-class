using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spelarensliv : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource dödsljudeffekt;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fällor"))
        {
            Dö();
        }
    }

    private void Dö()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Död");
        dödsljudeffekt.Play();
    }

    private void StartaOmLeveln()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
