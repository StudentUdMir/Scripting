using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{
    public Animator gatesAnim;

    void Start()
    {
        gatesAnim.enabled = false;
    }

    public void GatesOpen()
    {
        gatesAnim.enabled = true;
    }
}
