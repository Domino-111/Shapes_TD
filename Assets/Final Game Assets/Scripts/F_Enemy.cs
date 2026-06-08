using UnityEngine;
using System.Collections.Generic;

public class F_Enemy : MonoBehaviour
{
    public float health, speed;

    public F_Tower.Shape myShape;
    
    public GameObject[] goal;

    // Find target object to move towards before the first frame occurs
    void Awake()
    {
        goal = GameObject.FindGameObjectsWithTag("End");
    }

    // Destroy itself once health is zero or below and simply move straight towards the target
    void Update()
    {
        if (health <= 0)
        {
            GameManager.game.score++;
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, goal[0].transform.position, Time.deltaTime * speed);
    }
}
