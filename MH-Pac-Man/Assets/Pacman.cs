using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : Movement
{
   protected override void ChildUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //gets either 0 or 1
        float vertical = Input.GetAxisRaw("Vertical");

        float horizontal1 = Input.GetAxis("Horizontal"); //gets a decimal number under 1
        float vertical1 = Input.GetAxis("Vertical");

        Debug.Log("horizontal raw " + horizontal);
        Debug.Log("vertical raw " + vertical);
        Debug.Log("horizontal" + horizontal1);
        Debug.Log("vertical " + vertical1);

        transform.right = direction;

        if (horizontal != 0 || vertical != 0) //if pacman is not not moving
        {
            SetDirection(new Vector2(horizontal, vertical)); // move
        }
    }
}
