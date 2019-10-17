using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHP = 10;

    void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "playerBullet")
            {
                enemyHP--;
                if (enemyHP <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
