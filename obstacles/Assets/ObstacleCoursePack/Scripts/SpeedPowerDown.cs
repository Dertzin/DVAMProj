using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpeedPowerDown : MonoBehaviour
{
    private float speedDecrease = -5f;

    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            // Destroy all other player GameObjects except the one that collided with the power-up
            SlowOtherPlayers(colision.gameObject);
        }

    }

    void SlowOtherPlayers(GameObject playerToKeep)
    {
        // Find all GameObjects with the tag "Player"
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        // Destroy all player GameObjects except the one that collided with the power-up
        foreach (GameObject player in players)
        {
            if (player != playerToKeep)
            {
                player.gameObject.GetComponent<CharacterControls>().IncreaseOrDescreaseSpeed(speedDecrease);
                
                Destroy(gameObject);
            }
        }
    }
}
