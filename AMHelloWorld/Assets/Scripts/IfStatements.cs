using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //global variables
    public float coffeeTemp = 170.0f;
    float hotLimit = 180.0f;
    float coldLimit = 110.0f;

    // Update is called once per frame
    void Update()
    {
        //local variables
        if (coffeeTemp >= 80)
        {
            coffeeTemp -= Time.deltaTime * 5;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
    }

    void TemperatureTest()
    {
        if(coffeeTemp > hotLimit)
        {
            Debug.Log("Ouch! That's way too hot. Lawsuit time!");
        }
        else if(coffeeTemp < coldLimit)
        {
            Debug.Log("Yuck! That's way too cold. Can I speak to your manager?");
        }
        else
        {
            Debug.Log("Perfect! Oh, you want a tip? Sorry, I don't carry cash.");
        }
    }
}
