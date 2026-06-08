using System.Collections;
using UnityEngine;

public class F_Spawner : MonoBehaviour
{
    public GameObject tri, circ, hex;
    public Transform spawn;
    public float timer, resetTime, spawnRate;
    public int waveCounter;

    // Have a resetting timer going to increase the wave number
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            StartCoroutine("Spawn");

            waveCounter++;

            timer = resetTime;
        }
    }

    public IEnumerator Spawn()
    {
        // Spawn a circle enemy and stagger their spawn so it's visible there's multiple
        for (int i = 0; i < waveCounter; i++)
        {
            Instantiate(circ, spawn.position, Quaternion.identity, spawn);

            yield return new WaitForSeconds(spawnRate);
        }

        // Spawn a triangle enemy once wave 4 is reached and stagger their spawn so it's visible there's multiple
        if (waveCounter >= 4)
        {
            for (int i = 0; i < waveCounter - 3; i++)
            {
                Instantiate(tri, spawn.position, Quaternion.identity, spawn);

                yield return new WaitForSeconds(spawnRate);
            }
        }

        // Spawn a hexagon enemy once wave 7 is reached and stagger their spawn so it's visible there's multiple
        if (waveCounter >= 7)
        {
            for (int i = 0; i < waveCounter - 6; i++)
            {
                Instantiate(hex, spawn.position, Quaternion.identity, spawn);

                yield return new WaitForSeconds(spawnRate);
            }
        }
    }
}
