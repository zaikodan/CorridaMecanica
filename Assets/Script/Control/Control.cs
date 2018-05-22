using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    Model model;
    Vision vision;

    public Control()
    {
        vision = new Vision();
        model = new Model(vision.GetAmount());
        // Comentário whatever pra testar o git.
    }

    public void Buy(char product, int level)
    {
        if(model.GetProductCost(level) <= model.GetPlayerMoney())
        {
            model.Buy(product);
        }
    }

    public void RollDice()
    {
        if (model.GetRollDice())
        {
            model.RollDice();
        }
    }

    public void NextPlayer()
    {
        model.NextPlayer();
    }
}
