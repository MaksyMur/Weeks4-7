using UnityEngine;

public class ShowEmote : MonoBehaviour
{
    public Transform npc;
    public GameObject dialogue;

    public float showDistance = 2f;

    void Start()
    {
        //hide emote at the start
        dialogue.SetActive(false);
    }

    void Update()
    {
        //check distance between player and NPC
        float distance = Vector3.Distance(transform.position, npc.position);

        //if player is close, show emote
        if (distance < showDistance)
        {
            dialogue.SetActive(true);
        }
        //if player is far, hide emote
        else
        {
            dialogue.SetActive(false);
        }
    }
}