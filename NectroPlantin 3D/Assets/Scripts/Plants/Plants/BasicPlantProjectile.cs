using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BasicPlantProjectile : MonoBehaviour
{
    #region Target
    Transform TargetTransform;
    EnemyBehaviour enemy;
    #endregion

    #region PlantMan
    Rigidbody rb;
    Transform PlantMan;
    public float walkSpeed;
    #endregion

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        TargetTransform = FindObjectOfType<EnemyBehaviour>().GetComponent<Transform>();
        PlantMan = GetComponent<Transform>();
    }

    
    void Update()
    {
        PlantMan.transform.position = Vector3.MoveTowards(PlantMan.position, TargetTransform.position, walkSpeed* Time.deltaTime);
    }




}
