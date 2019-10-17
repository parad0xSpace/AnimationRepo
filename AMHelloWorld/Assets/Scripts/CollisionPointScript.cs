using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionPointScript : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "plus")
        {
            score++;
            
            Destroy(collision.gameObject);
            Debug.Log("Ding!");
        }
        if (collision.gameObject.tag == "minus")
        {
            score--;
            Destroy(collision.gameObject);
            Debug.Log("Ouch!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(score >=10)
        {
            SceneManager.LoadScene(3);
        }
        if(score <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
