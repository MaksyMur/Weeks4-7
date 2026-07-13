using UnityEngine;

public class BabyReward : MonoBehaviour
{
    //happy baby sprite
    public Sprite happySprite;

    //star prefab that will appear
    public GameObject starPrefab;

    //position where the star will appear
    public Transform starSpawnPoint;

    //how long the star stays in the scene
    public float starDuration = 3f;

    
    SpriteRenderer babySpriteRenderer;


    GameObject currentStar;

    //timer used to destroy the star
    float starTimer = 0f;

    //prevents the reward from appearing more than once
    bool rewardCreated = false;

    void Start()
    {
        //get the SpriteRenderer from the Baby object at runtime
        babySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //count down only while the star exists
        if (currentStar != null)
        {
            starTimer -= Time.deltaTime;

            //destroy the star when the timer reaches zero
            if (starTimer <= 0)
            {
                Destroy(currentStar);
            }
        }
    }

    public void GiveReward()
    {
        //dont create the reward again
        if (rewardCreated == false)
        {
            //change the sad baby to the happy baby
            babySpriteRenderer.sprite = happySprite;

            // Create the star prefab at the spawn point
            currentStar = Instantiate(
                starPrefab,
                starSpawnPoint.position,
                Quaternion.identity
            );

            //start the timer
            starTimer = starDuration;

            rewardCreated = true;
        }
    }
}