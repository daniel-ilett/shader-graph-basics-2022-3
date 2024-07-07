using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float rotateDistance;
    [SerializeField] private float rotateHeight;
    [SerializeField] private float rotateTimeOffset;

    private void Update()
    {
        float time = Time.time + rotateTimeOffset;
        float x = Mathf.Sin(time * rotateSpeed * Mathf.PI) * rotateDistance;
        float z = Mathf.Cos(time * rotateSpeed * Mathf.PI) * rotateDistance;
        float y = rotateHeight;

        Vector3 offset = new Vector3(x, y, z);
        transform.position = targetObject.position + offset;

        transform.LookAt(targetObject, Vector3.up);
    }
}
