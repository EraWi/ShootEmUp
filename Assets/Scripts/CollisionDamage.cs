using UnityEngine;
using System.Collections;

public class CollisionDamage : MonoBehaviour {

    public int health = 3;
    public float invulnPerioid = 0;
    int scoreValue = 200;
    float invulnTimer = 0;
    int correctLayer;
    public Animator anim;
    //public Animation animm;

    void Start()
    {
        correctLayer = gameObject.layer;
        anim.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //health--;
        invulnTimer = invulnPerioid;

        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");

        if (gameObject.tag == "Player" && collision.gameObject.tag != "Powerup")
        {
            LivesManager.currentHealth--;
            health--;
        }
        if(gameObject.tag == "Powerup")
        {
            //health--;
            Destroy(gameObject);
        }
        if(gameObject.tag == "Enemy")
        {
            health--;
        }
        gameObject.layer = 10;
    }

    void Update()
    {
        invulnTimer -= Time.deltaTime;
        
        if(invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }

        if (health <= 0)
        {
            Death();
        }

        //DEV KILL
        if (Input.GetKeyDown(KeyCode.B))
        {
            Death();
        }
    }

    public void Death()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");

        if (gameObject.tag == "Player")
        {
            if (LivesManager.currentLives > 0)
            {
                GetComponent<AudioSource>().Play();
                
                anim.enabled = true;
                anim.Play("exp", -1, 0f);
                anim.transform.position = player.transform.position;

                LivesManager.currentLives--;
                player.transform.position = new Vector3(-0.42f, -3.49f, 0);
                health = 3;
                LivesManager.currentHealth = 3;
            }
        }

        if(gameObject.tag == "Enemy")
        {
            GameObject audio = GameObject.Find("expsound");
            audio.GetComponent<AudioSource>().Play();

            Destroy(gameObject);
            ScoreManager.score += scoreValue;
        }

        if(gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            ScoreManager.score += scoreValue * 3;
        }
        //Destroy(gameObject);
    }
}
