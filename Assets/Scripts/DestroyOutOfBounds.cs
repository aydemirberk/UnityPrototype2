using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float topbound = 30;
    [SerializeField] float lowerbound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerbound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        
    }
}
