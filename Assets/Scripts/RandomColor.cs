using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var r = Random.value;
            var g = Random.value;
            var b = Random.value;

            var newColor = new Color(r, g, b);

            material.SetColor("_Color", newColor);
        }
    }
}
