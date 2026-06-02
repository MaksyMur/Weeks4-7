using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public GameObject existingRunner;
    public Vector3 spawnPosition;
    public float spawnSpeed = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Destroy the existing runner!
            Destroy(existingRunner, 3f);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Spawn a runner!
            //Instantiate(runnerPrefab);

            //Spawn a runner that is a child of this object
            //Instantiate(runnerPrefab, transform);

            //Spawn a runner at a specific position with no rotation:
            GameObject spawnedObject = Instantiate(runnerPrefab, transform.position, Quaternion.identity); //quaternion.identity means no rotation! 0 0 0 rotation!

            SpriteRenderer spawnedSpriteRenderer = GetComponent<SpriteRenderer>();
            spawnedSpriteRenderer.color = Color.red;
            Runner RunnerDude = spawnedObject.GetComponent<Runner>();

            //check to see if the omponent exists before trying to set the speed, otherwise we will get an error if it doesn't exist!
            if (RunnerDude != null)

                RunnerDude.speed = spawnSpeed;

            Destroy(spawnedObject, 2f);

            //POSITION OF ZERO:
            //Vector3 zeroVector = Vector3.zero;

            //ROTATION OF ZERO:
            //Quaternion zeroRotation = Quaternion.identity;
        }
    }
    public void OnSpawnPress()
    {
        //Spawn a runner!
        //Instantiate(runnerPrefab);

        //Spawn a runner that is a child of this object
        //Instantiate(runnerPrefab, transform);


        //Spawn a runner at a specific position with no rotation:
        GameObject spawnedObject = Instantiate(runnerPrefab, transform.position, Quaternion.identity);

        SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();
        if (spawnedSpriteRenderer != null)
        {
            spawnedSpriteRenderer.color = Color.red;
        }


        //MAKE THE SPAWNED OBJECT MOVE AT SPAWNSPEED:
        Runner spawnedRunner = spawnedObject.GetComponent<Runner>();

        //You should check to see if the component exists before using it
        if (spawnedRunner != null)
        {
            //DOES SPAWNED RUNNER HAVE A VALUE?
            spawnedRunner.speed = spawnSpeed;
        }


        Destroy(spawnedObject, 2f);
        //POSITION OF ZERO:
        //Vector3 zeroVector = Vector3.zero;

        //ROTATION OF ZERO:
        //Quaternion zeroRotation = Quaternion.identity;
    }

}
