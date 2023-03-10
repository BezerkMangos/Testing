using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
 
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    
    void Update()
    {
        if (CurrentHealth == 0)
        {
            Destroy(gameObject);
        }
        else
        {

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            TakeDamage();
            Debug.Log("You have " +CurrentHealth+ " health left.");
        
        }
        else
        {

        }
    }




    public void TakeDamage()
    {
        CurrentHealth = CurrentHealth - 1;
    }



}
