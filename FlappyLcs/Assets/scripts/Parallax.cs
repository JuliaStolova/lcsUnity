using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public float speed = 0.3f;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speed, 0) * Time.deltaTime;
    }
}
