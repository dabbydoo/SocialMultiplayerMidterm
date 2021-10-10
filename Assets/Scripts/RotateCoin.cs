using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rot = 100f;
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, rot) * Time.deltaTime);
    }
}
