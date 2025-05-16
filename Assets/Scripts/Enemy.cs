using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public int health, speed;

    public Tower.Shape myShape;

    void Start()
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
        //Vector3.MoveTowards(transform.position,);
    }
}
