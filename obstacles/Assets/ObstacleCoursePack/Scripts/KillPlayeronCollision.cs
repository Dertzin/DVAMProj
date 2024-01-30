using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayeronCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            colision.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
        }
    }
}
