using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mal : MonoBehaviour
{
    private AudioSource Malljud;

    private bool LevelKlarad = false;

    private void Start()
    {
        Malljud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "spelare" && !LevelKlarad)
        {
            Malljud.Play();
            LevelKlarad = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
