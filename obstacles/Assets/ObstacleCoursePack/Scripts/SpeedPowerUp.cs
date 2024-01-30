using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    private string[] playernumbers = { "1", "2", "3", "4" };
    [SerializeField] private float speedAmount;
    void OnTriggerEnter(Collider colision)
    {
        for (int i = 0; i <= playernumbers.Length; i++)
        {
            if (colision.gameObject.name == "Player" + playernumbers[i])
            {
                colision.gameObject.GetComponent<CharacterControls>().IncreaseOrDescreaseSpeed(speedAmount);
                Destroy(gameObject);
            }
        }
    }
}
