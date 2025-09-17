using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int damage, fireRate, boostCounter, killCount;

    private List<Enemy> enemiesInRange = new List<Enemy>();

    // Create a set list of shapes a tower or enemy can be
    public enum Shape 
    { circle, 
      triangle, 
      hexagon
    }

    public Shape towerShape;

    // Check if a matching enemy shape is within range
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

    // Check when enemies leave range
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
