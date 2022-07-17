using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    public Vector3 diceVelocity;
    public DicePhysics pickRoll;
    public int onRoll;

    public string[] settingArr = { "Graveyard", "Forest", "Castle" };
    public string[] enemiesArr = { "Wolves", "Goblins", "Skeletons" };
    public string[] difficultyArr = { "Easy", "Medium", "Hard" };

    // Update is called once per frame
    void FixedUpdate()
    {
        diceVelocity = DicePhysics.diceVelocity;
        onRoll = pickRoll.pickRoll;
    }
    
    // applies to all rigidbodies that enter the trigger (the dice trigger zone)
    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            if (onRoll == 1)
            {
                switch (col.gameObject.name)
                {
                    case "Side1":
                        DiceNumberToText.diceOutcome = settingArr[0]; // side 3 on top
                        break;
                    case "Side2":
                        DiceNumberToText.diceOutcome = settingArr[0]; // side 4 on top
                        break;
                    case "Side3":
                        DiceNumberToText.diceOutcome = settingArr[1]; // side 1 on top
                        break;
                    case "Side4":
                        DiceNumberToText.diceOutcome = settingArr[1]; // side 2 on top
                        break;
                    case "Side5":
                        DiceNumberToText.diceOutcome = settingArr[2]; // side 6 on top
                        break;
                    case "Side6":
                        DiceNumberToText.diceOutcome = settingArr[2]; // side 5 on top
                        break;

                }
            }
            else if (onRoll == 2)
            {
                switch (col.gameObject.name)
                {
                    case "Side1":
                        DiceNumberToText.diceOutcome = enemiesArr[0]; // side 3 on top
                        break;
                    case "Side2":
                        DiceNumberToText.diceOutcome = enemiesArr[0]; // side 4 on top
                        break;
                    case "Side3":
                        DiceNumberToText.diceOutcome = enemiesArr[1]; // side 1 on top
                        break;
                    case "Side4":
                        DiceNumberToText.diceOutcome = enemiesArr[1]; // side 2 on top
                        break;
                    case "Side5":
                        DiceNumberToText.diceOutcome = enemiesArr[2]; // side 6 on top
                        break;
                    case "Side6":
                        DiceNumberToText.diceOutcome = enemiesArr[2]; // side 5 on top
                        break;

                }
            }
            else if (onRoll == 3)
            {
                switch (col.gameObject.name)
                {
                    case "Side1":
                        DiceNumberToText.diceOutcome = difficultyArr[0]; // side 3 on top
                        break;
                    case "Side2":
                        DiceNumberToText.diceOutcome = difficultyArr[0]; // side 4 on top
                        break;
                    case "Side3":
                        DiceNumberToText.diceOutcome = difficultyArr[1]; // side 1 on top
                        break;
                    case "Side4":
                        DiceNumberToText.diceOutcome = difficultyArr[1]; // side 2 on top
                        break;
                    case "Side5":
                        DiceNumberToText.diceOutcome = difficultyArr[2]; // side 6 on top
                        break;
                    case "Side6":
                        DiceNumberToText.diceOutcome = difficultyArr[2]; // side 5 on top
                        break;

                }
            }
/*            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceNumberToText.diceOutcome = 3; // side 3 on top
                    break;
                case "Side2":
                    DiceNumberToText.diceOutcome = 4; // side 4 on top
                    break;
                case "Side3":
                    DiceNumberToText.diceOutcome = 1; // side 1 on top
                    break;
                case "Side4":
                    DiceNumberToText.diceOutcome = 2; // side 2 on top
                    break;
                case "Side5":
                    DiceNumberToText.diceOutcome = 6; // side 6 on top
                    break;
                case "Side6":
                    DiceNumberToText.diceOutcome = 5; // side 5 on top
                    break;

            }*/
        }
    }

}

