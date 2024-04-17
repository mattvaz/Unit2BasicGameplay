using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryBar : MonoBehaviour
{
   
    public class slider
    {
        internal static int value;
    } 

    public void UpgradeHungry(float current)
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
    }
}

public class DetectScores : MonoBehaviour
{
    static float score = 0;
    public float levelHungry = 2f;
    HungryBar floatingHungry;
    float feed = 0;

    private void Start()
    {
        floatingHungry = GetComponent<HungryBar>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(gameObject);
        else if (other.gameObject.CompareTag("Apple"))
        {
            feed++;
            floatingHungry.UpgradeHungry(1f);
            Destroy(other.gameObject);
            if (feed >= levelHungry)
            {
                score++;
                Debug.Log("Score: " + score);
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}