using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : Bird
{
    [SerializeField]
    public GameObject blast;
    public Renderer render;

    public void OnCollisionEnter2D(Collision2D other) {
        Collider.radius = 1f;
        Instantiate(blast, transform.position, Quaternion.identity);
        Destroy(this);
        render.enabled = false;
    }
}
