using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int speed = 5;
    const float gravity = 9.8f;
    CharacterController characterController;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }
    Vector3 moveVector;
    private void MoveCharacter()
    {
        moveVector = new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, Input.GetAxis("Vertical")*speed*Time.deltaTime); //karakterin x y z kordinatlarını alıyor. hız ile çarpıyor time delta time ilede smooh bir geçiş sağlıyor.
       moveVector= transform.TransformDirection(moveVector);//fare nereye bakıyorsa oraya göre hareket et
        if (!characterController.isGrounded)
        {
            moveVector.y -= Time.deltaTime * gravity; //karakter zeminde değilse onu zemine çek
        }
        characterController.Move(moveVector); //ve bunu karaktere veriyor. bu üç kodla karakter hareket eder. 
  //Move yerine SimpleMove yazarsan zıplama yapamaz her daim gravity i hesap eder. ve sadece yatay yönde hareket edebilirsin. ifi yazmana gerek kalmaz.

    }
}
