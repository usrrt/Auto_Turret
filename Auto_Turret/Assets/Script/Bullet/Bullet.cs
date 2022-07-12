using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // rigid
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    public float Speed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Speed);
    }
}
