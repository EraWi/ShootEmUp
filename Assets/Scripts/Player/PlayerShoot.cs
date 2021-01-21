using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject laserPrefab;
    public AudioSource powerUpSound;
   // public GameObject powerUp;

    float fireDelay = 0.25f;
    float fireDelayPowerUp = 0.1f;
    float cooldownTimer = 0;
    float powerUpTime = 2;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "powerup(Clone)")
        {
            fireDelay = fireDelayPowerUp;
            powerUpSound.Play();
            Invoke("DestroyPowerUp", 0.3f);
            Invoke("PowerUpDelay", 5);
        }
    }


    // Update is called once per frame
    void Update () {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(laserPrefab, transform.position + offset, transform.rotation);
        }

	}

    void PowerUpDelay()
    {
        fireDelay = 0.25f;
    }
    /*void DestroyPowerUp()
    {
        powerUp.SetActive(false);
    }*/
}
