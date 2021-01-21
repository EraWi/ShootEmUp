using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab2;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(EnemySpawnTimer());
    }

    IEnumerator EnemySpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(enemyPrefab2, enemyPrefab2.transform.position = new Vector3(Random.Range(-13.0f, 13.0f), Random.Range(5.6f, 7.5f), 0), enemyPrefab2.transform.rotation);
        }
    }
}
