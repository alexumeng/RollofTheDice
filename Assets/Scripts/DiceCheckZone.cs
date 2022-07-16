using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    public Vector3 diceVelocity;

    public int choices;

    public List<string> choicesList = new List<string>();

    public string[] possibilities = new string[6];

    // Update is called once per frame
    void FixedUpdate()
    {
        diceVelocity = DicePhysics.diceVelocity;
    }
    
    // applies to all rigidbodies that enter the trigger (the dice trigger zone)
    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceNumberToText.diceOutcome = choicesList[2]; // side 3 on top
                    break;
                case "Side2":
                    DiceNumberToText.diceOutcome = choicesList[3]; // side 4 on top
                    break;
                case "Side3":
                    DiceNumberToText.diceOutcome = choicesList[0]; // side 1 on top
                    break;
                case "Side4":
                    DiceNumberToText.diceOutcome = choicesList[1]; // side 2 on top
                    break;
                case "Side5":
                    DiceNumberToText.diceOutcome = choicesList[5]; // side 6 on top
                    break;
                case "Side6":
                    DiceNumberToText.diceOutcome = choicesList[4]; // side 5 on top
                    break;

            }
        }
    }

}

public void assignChoices()
{
    List<string> choicesList = ChoiceLoader.choicesList;
    int numbersPerChoice = 6 / choicesList.Count;
    int choice = 0;
    for (int i = 0; i < 6; i = i + numbersPerChoice)
    {
        int i_inc = i;
        int x = 0;
        while (x < numbersPerChoice)
        {
            possibilities[i_inc] = choicesList[choice];
            i_inc++;
            x++;
        }
        choice++;
    }
}
