using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tri, circ, hex;
    public Transform spawn;
    public float timer, resetTime;
    public int waveCounter;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Spawn();

            waveCounter++;

            timer = resetTime;
        }
    }

    public void Spawn()
    {
        Instantiate(circ, spawn);

        if (waveCounter >= 3)
        {
            Instantiate(tri, spawn);
        }

        if (waveCounter >= 5)
        {
            Instantiate(hex, spawn);
        }
    }
}
