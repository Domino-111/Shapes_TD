using UnityEngine;
using System.Collections.Generic;

public class F_Enemy : MonoBehaviour
{
    public float health, speed;

    public F_Tower.Shape myShape;
    
    public GameObject[] goal;

    public AudioSource lastBreath;

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
            if (myShape == F_Tower.Shape.circle)
            {
                F_GameManager.game.score += 10;
            }

            if (myShape == F_Tower.Shape.triangle)
            {
                F_GameManager.game.score += 20;
            }

            if (myShape == F_Tower.Shape.hexagon)
            {
                F_GameManager.game.score += 30;
            }

            lastBreath.Play();
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, goal[0].transform.position, Time.deltaTime * speed);
    }
}
