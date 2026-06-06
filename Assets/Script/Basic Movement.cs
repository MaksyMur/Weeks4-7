using UnityEngine;
using UnityEngine.InputSystem;

public class Basic_Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 newPosition = transform.position;

        //move right
        if (Keyboard.current.dKey.isPressed)
        {
            newPosition.x += moveSpeed * Time.deltaTime;
        }

        //move left
        if (Keyboard.current.aKey.isPressed)
        {
            newPosition.x -= moveSpeed * Time.deltaTime;
        }

        //move up
        if (Keyboard.current.wKey.isPressed)
        {
            newPosition.y += moveSpeed * Time.deltaTime;
        }

        //move down
        if (Keyboard.current.sKey.isPressed)
        {
            newPosition.y -= moveSpeed * Time.deltaTime;
        }

        transform.position = newPosition;
    }
}
