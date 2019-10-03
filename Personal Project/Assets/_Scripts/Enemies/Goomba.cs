using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour, IOnDeath
{
    public GameObject coin;

    public void OnHit()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
