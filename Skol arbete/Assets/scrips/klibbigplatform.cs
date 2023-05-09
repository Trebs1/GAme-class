using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klibbigplatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "spelare")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "spelare")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}