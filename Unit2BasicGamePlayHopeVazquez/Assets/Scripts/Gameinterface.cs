using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameinterface : MonoBehaviour
{
    // Instantiate static variable score, static can be inherited through the class not the object
    private static int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        score += 1;
        Debug.Log("Score: " + score);
    }
}
