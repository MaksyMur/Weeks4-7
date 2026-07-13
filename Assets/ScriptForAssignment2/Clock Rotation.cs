using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    public Transform minuteHand;
    public Transform hourHand;

    public float minuteSpeed = 30f;
    public float hourSpeed = 5f;

    void Update()
    {
        minuteHand.Rotate(0, 0, -minuteSpeed * Time.deltaTime);
        hourHand.Rotate(0, 0, -hourSpeed * Time.deltaTime);
    }
}