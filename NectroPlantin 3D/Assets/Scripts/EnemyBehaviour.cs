using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    #region Enemy Stats
    public int MaxHealth;
    public int CurrentHealth;
    #endregion

    #region Bullet Stuff
    public GameObject projectileGameObject;
    Vector3 projectileVector3;
    public float bulletSpeed;
    #endregion

    #region Target Stuff
    public GameObject TargetGameObject;
    public Transform TargetTransform;

    #endregion

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        projectileGameObject.transform.Translate(TargetTransform.transform.position * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        TargetTransform = other.GetComponent<Transform>();
        Instantiate(projectileGameObject);
        //projectileGameObject.transform.position = Vector3.MoveTowards(projectileGameObject.transform.position,other.transform.position, 50f);

    }






    




}
