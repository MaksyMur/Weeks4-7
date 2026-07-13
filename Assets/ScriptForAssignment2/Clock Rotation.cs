using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    public Transform minuteHand; //reference to the minute hand of the clock
    public Transform hourHand; //reference to the hour hand of the clock

    public float minuteSpeed = 30f; //speed of the minute hand rotation (degrees per second)
    public float hourSpeed = 5f; //speed of the hour hand rotation (degrees per second)

    void Update()
    {
        minuteHand.Rotate(0, 0, -minuteSpeed * Time.deltaTime); //rotate the minute hand based on the minute speed and time elapsed
        hourHand.Rotate(0, 0, -hourSpeed * Time.deltaTime); //rotate the hour hand based on the hour speed and time elapsed
    }
}