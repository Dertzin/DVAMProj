using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerprebab;
    [SerializeField] private Color player1Color;
    [SerializeField] private Color player2Color;
    [SerializeField] private Color player3Color;
    [SerializeField] private Color player4Color;
    [SerializeField] private int playerCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if(playerCount == 1)
        {
            PlayerSpawn("1",player1Color);
        }
        else if(playerCount == 2)
        {
            PlayerSpawn("1", player1Color);
            PlayerSpawn("2", player2Color);

        }
        else if(playerCount == 3)
        {
            PlayerSpawn("1", player1Color);
            PlayerSpawn("2", player2Color);
            PlayerSpawn("3", player3Color);
        }
        else if (playerCount == 4)
        {
            PlayerSpawn("1", player1Color);
            PlayerSpawn("2", player2Color);
            PlayerSpawn("3", player3Color);
            PlayerSpawn("4", player4Color);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerSpawn(string playernumber,Color color)
    {
        Vector3 offset = new Vector3(0.0f, 3.0f, 0.0f);

        GameObject player = Instantiate(playerprebab, transform.position + offset, Quaternion.identity);

        player.name = "Player" + playernumber;
        SetColor setColor = player.GetComponent<SetColor>();
        CharacterControls setplayernumber = player.GetComponent<CharacterControls>();

        setColor.ChooseColor(color);
        setplayernumber.SetPlayerNumber(playernumber);
    }
    public void SetPlayerSettings(Color player1color,int playercount)
    {
        player1color = player1Color;
        playerCount = playercount;
    }
    public void SetPlayerSettings(Color player1color,Color player2color,int playercount)
    {
        player1color = player1Color;
        player2color = player2Color;
        playerCount = playercount;
    }
    public void SetPlayerSettings(Color player1color,Color player2color, Color player3color,int playercount)
    {
        player1color = player1Color;
        player2color = player2Color;
        player3color = player3Color;      
        playerCount = playercount;
    }
    public void SetPlayerSettings(Color player1color,Color player2color, Color player3color, Color player4color,int playercount)
    {
        player1color = player1Color;
        player2color = player2Color;
        player3color = player3Color;
        player4color = player4Color;
        playerCount = playercount;
    }
}
