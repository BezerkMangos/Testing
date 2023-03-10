using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    Vector3 movementDirection;

    public float speed;
    public float dashSpeed;

    private bool canPlant = false;


    public GameObject plantGameObject;
    private PlantTile PlantTile;
    public GameObject plantTileSpawn;

    private GameObject PlayerGameObject;
    private Transform PlayerTransform;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        
        PlayerTransform = GetComponent<Transform>();
        PlayerGameObject = GetComponent<GameObject>();
    }

    
    void Update()
    {
        #region Physics Movment
        //Should be done in the FixedUpdate;
        /* 
        //Forward
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = rb.velocity * speed;
        }
        //Backwards
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
        //Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        //Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
        
        */
        #endregion
        #region Transform Movment
        /*
        
        //Forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward.normalized * Time.deltaTime * speed);
        }
        //Backwards
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back.normalized * Time.deltaTime * speed);
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left.normalized * Time.deltaTime * speed);
        }
        //Right
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right.normalized * Time.deltaTime * speed);
        }

        */
        #endregion
        #region Transform 8 Way Even movment

        movementDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical")); //Creates a new vector 3 thats gets the horizontal input and vertical and stores it
        transform.Translate(movementDirection.normalized * speed * Time.deltaTime); // Translates the object by the movementDirection everyframe at a set so
        
        
        
            #endregion
        //Active^

        //Run 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Dash();
        }
        //Planting
        if (Input.GetMouseButtonDown(0) && canPlant == true)
        {
            Plant();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlantTile")
        {
            canPlant = true;
            plantTileSpawn = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlantTile")
        {
            canPlant = false;
        }
    }

    


void Dash()
    {
        transform.Translate(movementDirection.normalized * dashSpeed * Time.deltaTime);
    }

    void Plant()
    {
       Instantiate(plantGameObject,new Vector3(plantTileSpawn.transform.position.x,0.3f, plantTileSpawn.transform.position.z), new Quaternion(0, 0, 0, 0));

    }

}
