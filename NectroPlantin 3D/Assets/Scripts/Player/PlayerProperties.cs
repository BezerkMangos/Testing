using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    public int MaxHealth = 10;
    public int CurrentHealth;
 
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    
    void Update()
    {
        
    }


}
