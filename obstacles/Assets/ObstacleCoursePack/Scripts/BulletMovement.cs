using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float movementSpeed;
    private string bulletDirections;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletDirections == "front")
        {
            transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
        }
        else if(bulletDirections == "back")
        {
            transform.Translate(0f, 0f, -1 * movementSpeed * Time.deltaTime);
        }
        else if(bulletDirections == "right")
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (bulletDirections == "left")
        {
            transform.Translate(-1 * movementSpeed * Time.deltaTime, 0f, 0f);
        }
        
    }

    public void SetDirection(string directions)
    {
        bulletDirections = directions;
    }
}
