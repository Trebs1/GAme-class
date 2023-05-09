using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banansparare : MonoBehaviour
{
    private int bananer = 0;

    [SerializeField] private Text bananText;

    [SerializeField] private AudioSource F�ngningsljudeffekt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Banan"))
        {
            F�ngningsljudeffekt.Play();
            Destroy(collision.gameObject);
            bananer++;
            bananText.text = "Bananer: " + bananer;
        }
    }
}
