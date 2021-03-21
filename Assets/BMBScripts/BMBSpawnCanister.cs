using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBSpawnCanister : MonoBehaviour
{

    [SerializeField] Transform[] spawnpoints;

    [SerializeField] GameObject[] canisterPrefabs;

    [SerializeField] float spawnTime;

    private void Start()
    {
        StartCoroutine(SpawnCanisterTimer());
    }

    IEnumerator SpawnCanisterTimer()
    {
        int randPrefab = Random.Range(0, canisterPrefabs.Length);
        int randPos = Random.Range(0, spawnpoints.Length);
        GameObject canisterInstance = Instantiate(canisterPrefabs[randPrefab], spawnpoints[randPos].position, Quaternion.Euler(90, 0, 0));
        yield return new WaitForSeconds(spawnTime);
        Destroy(canisterInstance);
        StartCoroutine(SpawnCanisterTimer());
    }

}
