using UnityEngine;
using UnityEngine.InputSystem;

public class RotateClockHand : MonoBehaviour
{
    public float moveSpeed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPosition = transform.position;  
        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld)
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }
        bool isRightHeld = Keyboard.current.rightArrowKey.isPressed;
        if (isRightHeld)
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;

            Debug.Log(transform.position);
        }

        

    }
}

