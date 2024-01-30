using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseP1Color : MonoBehaviour
{
    private Color color1;
    private Color color2;
    private Color color3;
    private Color color4;

    // Start is called before the first frame update
    public void ChooseP1Red()
    {
        color1 = Color.red;
    }
    
    public void ChooseP1Green()
    {
        color1 = Color.green;
    }

    public void ChooseP1Blue()
    {
        color1 = Color.blue;
    }
    

    public void ChooseP2Red()
    {
        color2 = Color.red;
    }

    public void ChooseP2Green()
    {
        color2 = Color.green;
    }

    public void ChooseP2Blue()
    {
        color2 = Color.blue;
    }

    public void ChooseP3Red()
    {
        color3 = Color.red;
    }

    public void ChooseP3Green()
    {
        color3 = Color.green;
    }

    public void ChooseP3Blue()
    {
        color3 = Color.blue;
    }

    public void ChooseP4Red()
    {
        color4 = Color.red;
    }

    public void ChooseP4Green()
    {
        color4 = Color.green;
    }

    public void ChooseP4Blue()
    {
        color4 = Color.blue;
    }
    public void PlayP1Game()
    {
        SpawnPlayer spawnPlayer = GetComponent<SpawnPlayer>();
        spawnPlayer.SetPlayerSettings(color1, 1);
    }

    public void PlayP2Game()
    {
        SpawnPlayer spawnPlayer = GetComponent<SpawnPlayer>();
        spawnPlayer.SetPlayerSettings(color1,color2, 2);
    }

    public void PlayP3Game()
    {
        SpawnPlayer spawnPlayer = GetComponent<SpawnPlayer>();
        spawnPlayer.SetPlayerSettings(color1,color2,color3, 3);
    }

    public void PlayP4Game()
    {
        SpawnPlayer spawnPlayer = GetComponent<SpawnPlayer>();
        spawnPlayer.SetPlayerSettings(color1, color2, color3,color4, 4);
    }
}
