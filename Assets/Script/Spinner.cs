using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hi!");
        //Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;



       
    }
}
