using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            // Destroy all other player GameObjects except the one that collided with the power-up
            KillOtherPlayers(colision.gameObject);
        }

    }
    void KillOtherPlayers(GameObject playerToKeep)
    {
        // Find all GameObjects with the tag "Player"
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        // Destroy all player GameObjects except the one that collided with the power-up
        foreach (GameObject player in players)
        {
            if (player != playerToKeep)
            {
                player.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();

                Destroy(gameObject);
            }
        }
    }
}
