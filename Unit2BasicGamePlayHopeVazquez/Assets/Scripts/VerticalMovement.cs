using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float sideBoundry = 20.0f;
    private float forwardBoundry = 0;
    private float backBoundry = -13.5f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Set the players front/back boundries
        if (transform.position.z > forwardBoundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, forwardBoundry);
        }

        if (transform.position.z < backBoundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, backBoundry);
        }



        //Set players side boundries
        if (transform.position.x < -sideBoundry)
        {
            transform.position = new Vector3(-sideBoundry, transform.position.y, transform.position.z);
        }

        if (transform.position.x > sideBoundry)
        {
            transform.position = new Vector3(sideBoundry, transform.position.y, transform.position.z);
        }

        //Player Side Movments
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Player Forward Movment
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        // Start is called before the first frame update

    }
}
