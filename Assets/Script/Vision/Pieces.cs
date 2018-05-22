using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour {

    Control control;
    [SerializeField]
    private char product;
    [SerializeField]
    private int level;

    public Pieces()
    {
        control = new Control();
    }

    private void OnMouseUp()
    {
        control.Buy(product, level);
    }
}
