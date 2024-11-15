using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 1f;
    float leftEdge;

    void Start() {

        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;

    }

    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
