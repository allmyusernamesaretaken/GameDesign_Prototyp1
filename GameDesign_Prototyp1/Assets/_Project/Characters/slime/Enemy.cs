using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    public float Health
    {
        set
        {
            health = (int)value;
            if(Health <= 0)
            {
                Defeated();
            }
        }
        get
        {
            return health;
        }
    }

    public void Defeated()
    {
        Destroy(gameObject);
    }
}
