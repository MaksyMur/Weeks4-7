using UnityEngine;

public class FeedButton : MonoBehaviour
{
    public Transform baby;

    public Vector3 normalScale;
    public Vector3 bigScale;

    public float pulseSpeed = 5f;

    bool isPulsing = false;
    float timer = 0f;

    void Start()
    {
        normalScale = baby.localScale;
        bigScale = normalScale * 1.2f;
    }

    void Update()
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

    public void FeedBaby()
    {
        timer = 0f;
        isPulsing = true;
    }
}