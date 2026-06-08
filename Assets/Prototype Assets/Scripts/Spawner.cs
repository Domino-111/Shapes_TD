using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tri, circ, hex;
    public Transform spawn;
    public float timer, resetTime, spawnRate;
    public int waveCounter;

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
        for (int i = 0; i < waveCounter; i++)
        {
            Instantiate(circ, spawn.position, Quaternion.identity, spawn);

            yield return new WaitForSeconds(spawnRate);
        }

        if (waveCounter >= 4)
        {
            for (int i = 0; i < waveCounter - 3; i++)
            {
                Instantiate(tri, spawn.position, Quaternion.identity, spawn);

                yield return new WaitForSeconds(spawnRate);
            }
        }

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
