using UnityEngine;
using UnityEngine.Events;

public class ProximityHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;

    public UnityEvent onTrappedEntered;
    public UnityEvent onTrappedExited;

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
           onTrappedEntered.Invoke(); //everything that involeved gets triggered
            isCurrentlyOnTrap = true;

        }
        //we were on the trap, but now we are not
        if (!playerRenderer.bounds.Contains(transform.position)
            && isCurrentlyOnTrap)
        {
            onTrappedExited.Invoke();
            isCurrentlyOnTrap = false;

        }
    }
}
