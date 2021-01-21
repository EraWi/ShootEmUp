using UnityEngine;
using System.Collections;

public class PowerUpSpawner2 : MonoBehaviour {

    public GameObject powerUpPrefab2;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(PowerSpawnTimer());
    }

    IEnumerator PowerSpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(powerUpPrefab2, powerUpPrefab2.transform.position = new Vector3(Random.Range(-12.0f, 12.0f), Random.Range(4f, -4f), 0), powerUpPrefab2.transform.rotation);
        }
    }
}
