using UnityEngine;

public class FeedButton : MonoBehaviour
{
    public Transform baby;

    public Vector3 normalScale; //baby's normal scale
    public Vector3 bigScale; //baby's scale when pulsing

    public float pulseSpeed = 5f; //speed of the pulsing effect

    bool isPulsing = false; //flag to check if the pulsing effect is active
    float timer = 0f; //timer to track the pulsing effect

    void Start()
    //initialize the normal and big scales based on the baby's current scale
    {
        normalScale = baby.localScale;
        bigScale = normalScale * 1.2f;
    }

    void Update()
    //update the pulsing effect if it's active
    {
        if (isPulsing)
        {
            timer += Time.deltaTime * pulseSpeed;

            if (timer < 0.5f)
            {
                baby.localScale = Vector3.Lerp(normalScale, bigScale, timer * 2f);
            }
            else
            {
                baby.localScale = Vector3.Lerp(bigScale, normalScale, (timer - 0.5f) * 2f);
            }

            if (timer >= 1f)
            {
                baby.localScale = normalScale;
                timer = 0f;
                isPulsing = false;
            }
        }
    }
//method to trigger the pulsing effect when the feed button is pressed
    public void FeedBaby() //
    {
        timer = 0f;
        isPulsing = true;
    }
}