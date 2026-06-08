using System.Collections.Generic;
using UnityEngine;

public class F_Tower : MonoBehaviour
{
    public float damage, fireRate, boostCounter, killCount;

    private List<F_Enemy> enemiesInRange = new List<F_Enemy>();

    public F_Enemy enemy;

    // <Addition: Create a line between tower and enemy to show which one it's attacking>
    public LineRenderer beam;

    // Create a set list of shapes a tower or enemy can be
    public enum Shape 
    { circle, 
      triangle, 
      hexagon
    }

    // Have visible selector for tower shape in Unity editor for quick changes
    public Shape towerShape;

    // <Addition: Determine how many points the line will have>
    void Start()
    {
        beam.positionCount = 2;
    }

    // Once an enemy is in range attack it
    void Update()
    {
        if (enemiesInRange.Count>0)
        {
            Attack();
            beam.SetPosition(0, transform.position);
            beam.SetPosition(1, enemy.transform.position);
        }

        else
        {
            beam.SetPosition(0, transform.position);
            beam.SetPosition(1, transform.position);
        }
    }

    // Check if a matching enemy shape is within range
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<F_Enemy>(out F_Enemy combatant))
        {
            if (combatant.myShape == towerShape)
            {
                enemiesInRange.Add(combatant);
                enemy = combatant;
            }
        }
    }

    // Check when enemies leave range
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<F_Enemy>(out F_Enemy combatant))
        {
            enemiesInRange.Remove(combatant);
        }
    }

    // Lower the enemies health
    private void Attack()
    {
        enemy.health -= Time.deltaTime * damage;
    }
}
