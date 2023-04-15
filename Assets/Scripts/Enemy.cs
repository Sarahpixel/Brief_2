using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //public int value = 50;
    //private Camera mainCamera;
    public float EnemyHealth = 10;

    public Transform vfxDeath;
    //public float speed = 8.0f;
    private Rigidbody enemyRb;
    //private Vector3 screenBounds;
    //private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        //enemyRb.velocity = new Vector3(-speed, 0);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        //player = GameObject.Find("Player");
    }
    //void Update()
    //{
    //    Vector2 screenPosition = mainCamera.WorldToScreenPoint(transform.position);
    //    //if (transform.position.x < screenBounds.x * 5)
    //    //{
    //    //    Destroy(this.gameObject);
    //    //}
    //    //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
    //    //enemyRb.AddForce(lookDirection * speed);
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    ScoreManager.Instance.Score += value;
    //}
    public void TakeDamage(int damage)
    {
       
        EnemyHealth -= damage;

        if (EnemyHealth <= 0)
        {

            Invoke(nameof(DestroyEnemy), 1f);
            Instantiate(vfxDeath, transform.position, Quaternion.identity);
        }
        
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
