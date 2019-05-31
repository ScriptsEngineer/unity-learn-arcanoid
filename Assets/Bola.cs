using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

  // Use this for initialization
  public Vector2 Velocidade;

  void Start()
  {

    Rigidbody2D rigidBody = GetComponent<Rigidbody2D>(); // contem uma referência a o rigidBody da bolinha


    rigidBody.AddForce(Velocidade);

  }

}
