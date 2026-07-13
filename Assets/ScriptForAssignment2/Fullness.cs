using UnityEngine;
using UnityEngine.UI;

public class Fullness : MonoBehaviour
{
    //shows hoow full the baby is
    public Slider FullnessSlider;

    //for the script
    public BabyReward babyReward;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Feed()
    {
       if (FullnessSlider.value < FullnessSlider.maxValue) //check if the slider is not already full
       {
            FullnessSlider.value += 1; //increase the slider value by 1
    }
     //give the reward when the slider reaches its maximum
        if (FullnessSlider.value >= FullnessSlider.maxValue)
        {
             babyReward.GiveReward();
         }
    }
    
}

