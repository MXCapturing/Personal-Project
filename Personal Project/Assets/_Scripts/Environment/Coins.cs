using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Player"))
        {
            PlayerCoinCount.instance.coinCount += coinValue;
            Destroy(gameObject);
        }
    }
}
