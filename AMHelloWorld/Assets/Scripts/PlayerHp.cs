using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public int hp = 10;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Oops!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            hp--; 
            //same as hp -= or hp -1
            if(hp < 1)
            {
                //die
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene("HahaLoser");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemyBullet")
        {
            hp--;
            if (hp < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
