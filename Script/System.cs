using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System : MonoBehaviour {

    public int diceValue;

    public void RollDice()
    {
        diceValue = Random.Range(1, 12);
    }
}
