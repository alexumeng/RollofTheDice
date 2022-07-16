using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    Vector3 diceVelocity;

    // Update is called once per frame
    void FixedUpdate()
    {
        diceVelocity = DicePhysics.diceVelocity;
    }
    
    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceNumberToText.diceNumber = 6;
                    break;
                case "Side2":
                    DiceNumberToText.diceNumber = 5;
                    break;
                case "Side3":
                    DiceNumberToText.diceNumber = 4;
                    break;
                case "Side4":
                    DiceNumberToText.diceNumber = 3;
                    break;
                case "Side5":
                    DiceNumberToText.diceNumber = 2;
                    break;
                case "Side6":
                    DiceNumberToText.diceNumber = 1;
                    break;

            }
        }
    }
}
