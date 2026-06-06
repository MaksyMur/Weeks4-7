using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Required for Unity 6 input package (eyeroll)

public class Player_Movement : MonoBehaviour
{

    public float moveSpeed = 5f;

    //public Rigidbody2D rb;

    

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Reads Unity 6's default global WASD/Arrow layout with zero menu setup
        movement = InputSystem.actions["Move"].ReadValue<Vector2>();

        // This is the new stuff Kit was talking about. Need to added this check to make sure keyboard is connected
        if (Keyboard.current != null)
        {
            // Use A/D or Left/Right Arrow keys (-1 to 1)
            float moveX = Keyboard.current.dKey.ReadValue() - Keyboard.current.aKey.ReadValue();
            if (moveX == 0) moveX = Keyboard.current.rightArrowKey.ReadValue() - Keyboard.current.leftArrowKey.ReadValue();

            // Use W/S or Up/Down Arrow keys (-1 to 1)
            float moveY = Keyboard.current.wKey.ReadValue() - Keyboard.current.sKey.ReadValue();
            if (moveY == 0) moveY = Keyboard.current.upArrowKey.ReadValue() - Keyboard.current.downArrowKey.ReadValue();


            // All the old stuff. Any students looking at this, I (Rocco) wrote this. I'm an art teacher not a programer. Listen to Prof. Kit! Don't use this... write your own.

            movement.x = moveX; // slight change
            movement.y = moveY;

            
        }
    }


    
}
