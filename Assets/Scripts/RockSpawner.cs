using UnityEngine;
using System.Collections;

public class RockSpawner : MonoBehaviour {

    public GameObject rockPrefab;
    public GameObject rockPrefab2;

    // Use this for initialization
    void Start () {
        StartCoroutine(RockSpawnTimer());
	}

    IEnumerator RockSpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Instantiate(rockPrefab, rockPrefab.transform.position = new Vector3(Random.Range(-13.0f, 13.0f), Random.Range(5.6f, 7.5f), 0), rockPrefab.transform.rotation);
            Instantiate(rockPrefab2, rockPrefab2.transform.position = new Vector3(Random.Range(-13.0f, 13.0f), Random.Range(5.6f, 7.5f), 0), rockPrefab2.transform.rotation);
        }
    }
}
