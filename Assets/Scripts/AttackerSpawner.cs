using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float shortestSpawnTime = 1f;
    [SerializeField] float longestSpawnTime = 5f;
    [SerializeField] Attacker attackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(shortestSpawnTime, longestSpawnTime));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
}
