using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    #region Properties
    public int MaxHealth;
    public int CurrentHealth;
    Vector3 pos;

    #endregion

    bool spawnBullet;
    public GameObject bulletGameObject;
    void Start()
    {
        pos = transform.position;
        CurrentHealth = MaxHealth;
    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }

    #region Triggers
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            spawnBullet = true;
            SpawnBullet();
        }
        else
        {

        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            spawnBullet = false;

        }
        else
        {

        }
    }
    #endregion

    #region Spawn Bullet Method
    void SpawnBullet()
    {
        if (spawnBullet)
        {
            Instantiate(bulletGameObject, pos + new Vector3(0, 0.5f, 0), Quaternion.identity);

        }
        else
        {
            
        }
    }
    #endregion

    #region Collisions

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PlantMan")
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
    

    #endregion

    #region Take Damage Method

    private void TakeDamage()
    {
        CurrentHealth = CurrentHealth - 1;
    }

    #endregion






}
