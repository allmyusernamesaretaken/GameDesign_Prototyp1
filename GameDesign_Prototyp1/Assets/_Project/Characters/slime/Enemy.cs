using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    [SerializeField] private int health = 100;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
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
        animator.SetTrigger("defeated");
    }

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
}
