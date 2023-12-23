using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 2;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
