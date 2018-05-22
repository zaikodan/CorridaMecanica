using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour {

    Control control;

   private void OnMouseUp()
    {
        control = new Control();
        control.NextPlayer();
    }
}
