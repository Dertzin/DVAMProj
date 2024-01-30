using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{

    private bool haveWinner = false;

    [SerializeField] GameObject player1message;
    [SerializeField] GameObject player2message;
    [SerializeField] GameObject player3message;
    [SerializeField] GameObject player4message;
    
 
    private void OnTriggerEnter(Collider other)
    {
        
        if (!haveWinner)
        {
            if (other.gameObject.name == "Player1")
            {
                player1message.SetActive(true);
            }
            else if (other.gameObject.name == "Player2")
            {
                player2message.SetActive(true);
            }
            else if (other.gameObject.name == "Player3")
            {
                player3message.SetActive(true);
            }
            else if (other.gameObject.name == "Player4")
            {
                player4message.SetActive(true);
            }
            haveWinner = true;
        }
    }
}
