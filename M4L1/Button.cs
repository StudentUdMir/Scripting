using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Gates gates;

    void Start()
    {
        button.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        gates.GatesOpen();
    }
}
