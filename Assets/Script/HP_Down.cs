using UnityEngine;
using TMPro;

public class HP_Down : MonoBehaviour
{
    public TMP_Text healthText;

    public HealthBar enemyHealth;

    void Update()
    {
        healthText.text = "HP: " + enemyHealth.health;
    }
}