using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int playerLevel { get; private set; }
    public int playerMaxExp { get; private set; }
    public int playerCurrentExp;
    
    public string playerName;


    private void Start()
    {
        playerLevel = 1;
        playerMaxExp = 100;
        playerCurrentExp = 0;
    }

    private void Update()
    {
        if (playerMaxExp <= playerCurrentExp)
        {
            //increase the level by 1
            playerLevel++;
            //access EXP will be shifted to the next level
            playerCurrentExp = playerCurrentExp - playerMaxExp;
            //Set the next max exp
            playerMaxExp = playerLevel*100;
        }
    }
}
