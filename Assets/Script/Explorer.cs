using UnityEngine;
using UnityEngine.InputSystem;

public class Explorer : MonoBehaviour
{
    public float health;
    public float speed;
    public int treasure;

    public SpriteRenderer explorerColor;

    public float freezeTimer = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToMove = Vector3.zero;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }
        transform.position += directionToMove * speed * Time.deltaTime;

        if (freezeTimer >= 0)
        {
            freezeTimer -= Time.deltaTime;
        }
        if (freezeTimer <= 0)

        {
            speed = 3f;
            explorerColor.color = Color.white;

        }

    }
    public void TakeDamage()
    {
        health -= 10;
    }
    public void RestoreHP()
    {
        health += 10;
    }
    public void SlowDown()
        {
        speed -= 1.5f;
        
    }
    public void SpeedUp()
    {
        speed += 1.5f;
    }
    public void Freeze()
    {
        speed = 0;
       explorerColor.color = Color.cyan;
        freezeTimer = 1f;


    }
}
