using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaPingPong : MonoBehaviour
{
    [SerializeField] private float speed;
    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        float t = Time.time * speed;
        float a = (Mathf.Sin(t) + 1.0f) * 0.5f;
        Color col = material.GetColor("_Base_Color");
        col.a = a;
        material.SetColor("_Base_Color", col);
    }
}
