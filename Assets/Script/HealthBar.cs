using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health = 3;

    void OnMouseDown()
    {
        //lose 1 health when clicked
        health--;

        Debug.Log("Health: " + health);

        //destroy enemy at 0 health
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}