using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
   private Rigidbody playerRb;
   public float moveSpeed = 10;
   public Vector2 moveVal;
   

   private void Awake()
   {
      playerRb = GetComponent<Rigidbody>();
      

   }

   public void Moving(InputAction.CallbackContext value)
   {
       if (value.performed)
       { 
           moveVal = value.ReadValue<Vector2>();

       }

     if (value.canceled)
     { 
         moveVal = value.ReadValue<Vector2>();
     }

   }
   
}
