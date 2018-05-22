﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int currentHouse;
    private int money;
    private int engine;
    private int tire;
    private int transmission;
    private int brake;
    private int chassis;

    public Player ()
    {
        currentHouse = 0;
        money = 400;
        engine = 1;
        tire = 1;
        transmission = 1;
        brake = 1;
        chassis = 7;
    }

    public int GetCurrentHouse()
    {
        return currentHouse;
    }

    public void UpgradeEngine()
    {
        engine++;
    }

    public void UpgradeBrake()
    {
        brake++;
    }

    public void UpgradeTransmission()
    {
        transmission++;
    }

    public void UpgradeTire()
    {
        tire++;
    }

    public void UpgradeChassis()
    {
        chassis++;
    }

    public void PayMoney()
    {
        money -= 100;
    }
}
