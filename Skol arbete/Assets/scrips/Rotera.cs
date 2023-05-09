using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotera : MonoBehaviour
{
    [SerializeField] private float fart = 2f;
    private void Update()
    {
        transform.Rotate(0, 0, 360 * fart *Time.deltaTime);
    }
}
