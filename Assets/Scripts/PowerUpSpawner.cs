using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour {

    public GameObject powerUpPrefab;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(PowerSpawnTimer());
    }

    IEnumerator PowerSpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(powerUpPrefab, powerUpPrefab.transform.position = new Vector3(Random.Range(-12.0f, 12.0f), Random.Range(4f, -4f), 0), powerUpPrefab.transform.rotation);
        }
    }
}

