using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrollerare : MonoBehaviour
{
    [SerializeField]private Transform spelare;

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(spelare.position.x, spelare.position.y, transform.position.z);
    }
}
