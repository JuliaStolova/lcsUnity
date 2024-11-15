using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 moveDirection;
    public float gravity = -10f;
    public float jumpForce = 3f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    int spriteIndex = 0;


    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeSprite", 0.15f, 0.15f);
    }

    void ChangeSprite() {
        spriteIndex++;
        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        } 
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            moveDirection = Vector3.up * jumpForce;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                moveDirection = Vector3.up * jumpForce;
            }
        }

        moveDirection.y += gravity * Time.deltaTime;
        transform.position += moveDirection * Time.deltaTime;
    }
}