using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    public GameObject Target;
    public Transform TargetTransform;
    public float speed;

    PlayerMovement player;

    void Start()
    {
        TargetTransform = FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
    }

    void Update()
    {
        TargetTransform = FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
        transform.Translate(TargetTransform.position * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Map")
        {
            Destroy(gameObject);
        }
        else
        {

        }
    }



}
