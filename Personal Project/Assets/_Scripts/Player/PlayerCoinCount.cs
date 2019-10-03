using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinCount : MonoBehaviour
{
    public static PlayerCoinCount instance;
    public int coinCount;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
    }
}
