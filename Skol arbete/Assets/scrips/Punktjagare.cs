using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punktjagare : MonoBehaviour
{
    [SerializeField] private GameObject[] Punkter;
    private int Nuvarandepunktinedx = 0;

    [SerializeField] private float fart = 2f;

    private void Update()
    {
        if (Vector2.Distance(Punkter[Nuvarandepunktinedx].transform.position, transform.position) < .1f)
        {
            Nuvarandepunktinedx++;
            if (Nuvarandepunktinedx >= Punkter.Length)
            {
                Nuvarandepunktinedx = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Punkter[Nuvarandepunktinedx].transform.position, Time.deltaTime * fart);
    }
}
