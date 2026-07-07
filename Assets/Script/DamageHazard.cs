using UnityEngine;

public class DamageHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;

    bool isCurrentlyOnTrap = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //not on the trap-first step
        if (playerRenderer.bounds.Contains(transform.position)
            && !isCurrentlyOnTrap)
        {
            playerExplorer.health -= 10;
            isCurrentlyOnTrap = true;
           
        }
        //we were on the trap, but now we are not
        if (!playerRenderer.bounds.Contains(transform.position))
        {
            isCurrentlyOnTrap = false;

        }
    }
}
