using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public float health, speed;

    public Tower.Shape myShape;
    
    public GameObject[] goal;

    void Awake()
    {
        goal = GameObject.FindGameObjectsWithTag("End");
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, goal[0].transform.position, Time.deltaTime * speed);
    }
}
