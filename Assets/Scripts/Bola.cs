using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    // Use this for initialization
    public Vector2 Velocidade;
    public int num = 2;

    public SpriteRenderer spriteRenderer;
    

    public void Soma()
    {
        Debug.Log(2+num);
    }

    private void Awake()
    {
        Soma();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>(); // contem uma referência a o rigidBody da bolinha


        rigidBody.AddForce(Velocidade);

    }

    private void Update()
    {
        spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
