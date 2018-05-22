using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {

    private int round;
    private int currentPlayer;
    private char[] typeHouse;
    private Player[] players;
    private bool rollDice;
    private Vision vision;


    public Model(int amount)
    {
        round = 1;
        currentPlayer = 0;
        players = new Player[amount];
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
    }

    public int GetProductCost(int level)
    {
        return level *= 100;
    }

    public int GetPlayerMoney()
    {
        return players[currentPlayer].GetMoney();
    }

    public void Buy(char product)
    {
        switch (product)
        { 
            case 'm':
                players[currentPlayer].UpgradeEngine();
                break;
            case 'p':
                players[currentPlayer].UpgradeTire();
                break;
            case 't':
                players[currentPlayer].UpgradeTransmission();
                break;
            case 'f':
                players[currentPlayer].UpgradeBrake();
                break;
            case 'c':
                players[currentPlayer].UpgradeChassis();
                players[currentPlayer].PayMoney();
                break;
        }
        players[currentPlayer].PayMoney();
    }

    public int GetDiceValue()
    {
        return Random.Range(1, 12);
    }

    public bool GetRollDice()
    {
        return rollDice;
    }

    public void RollDice()
    {
        players[currentPlayer].currentHouse += GetDiceValue();
        rollDice = true;
        players[currentPlayer].Movement();
    }

    public void NextPlayer()
    {
        vision = new Vision();
        if (currentPlayer == vision.GetAmount())
        {
            currentPlayer = 0;
        }
        else { currentPlayer++;
        }

        rollDice = false;
        round++;

        if(round > 10)
        {
            EndGame();
        }
    }

    private void EndGame()
    {

    }
}
