using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maggie : Hero
{
    protected override void Movement()
    {
       
        base.Movement();
        anim.SetFloat("Move", movementValue);
      
    }
}
