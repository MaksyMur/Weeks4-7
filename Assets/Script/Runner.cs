using UnityEngine;

public class Runner : MonoBehaviour
{
    bool isMoving = false;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    void OnMOveClick()
    {
    isMoving = true;
    }

}
