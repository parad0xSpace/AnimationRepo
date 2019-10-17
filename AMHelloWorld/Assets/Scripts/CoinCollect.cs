using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int wallet = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            wallet++;
            Destroy(collision.gameObject);
        }
    }
}
