using UnityEngine;
using System.Collections;

public class RandomSpawnController : MonoBehaviour {

    public GameObject enemyPrefab;

    bool spawningEnabled;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(EnemySpawnTimer());
        //StartCoroutine(PowerUpSpawnTimer());
    }

    IEnumerator EnemySpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemyPrefab, enemyPrefab.transform.position = new Vector3(Random.Range(-17.0f, 17.0f), Random.Range(5.6f, 7.5f), 0), enemyPrefab.transform.rotation);
        }
    }

    /*IEnumerator PowerUpSpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            Instantiate(powerUpPrefab, powerUpPrefab.transform.position = new Vector3(Random.Range(-12.72f, 12.72f), Random.Range(-3.93f, 3.93f), 0), powerUpPrefab.transform.rotation);
        }
    }*/
}
