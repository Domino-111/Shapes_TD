using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int damage, fireRate, boostCounter, killCount;

    private List<Enemy> enemiesInRange = new List<Enemy>();

    public enum Shape 
    { circle, 
      triangle, 
      hexagon
    }

    public Shape towerShape;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy combatant))
        {
            if (combatant.myShape == towerShape)
            {
                enemiesInRange.Add(combatant);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy combatant))
        {
            enemiesInRange.Remove(combatant);
        }
    }

    private void Attack()
    {
        
    }
}
