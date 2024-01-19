using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMessage : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Canvas canvas;
    private bool hasJumpedOnBox = false;
    void Start()
    {
        canvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            canvas.enabled = true;
            hasJumpedOnBox = true;
        }
    }

    private void Update()
    {
        if (hasJumpedOnBox)
        {
            // Assuming the box is in the positive Z direction
            float playerYPosition = this.transform.position.y;

            // Restrict player's movement beyond the box
            transform.position = new Vector3(transform.position.x, Mathf.Max(transform.position.z, playerYPosition),transform.position.z);
        }
    }
}
