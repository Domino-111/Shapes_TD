using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public int health, speed;

    public Transform goal;

    public Tower.Shape myShape;

    void Awake()
    {
        
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Movement()
    {
        Vector3.MoveTowards(transform.position, goal.position, 10000);
    }
}
