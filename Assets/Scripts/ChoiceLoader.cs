using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceLoader : MonoBehaviour
{
    public int mission_id = 0000;

    public List<string> choicesList = new List<string>();

    void missionChoiceAssignment(int mission_id)
    {
        if (mission_id == 0000)
        {
            // default values in die

            for (int i = 1; i <= 6; i++)
            {
                choicesList[i] = i.ToString();
            }
        }
        else if (mission_id == 0001)
        {
            choicesList[0] = "Forest";
            choicesList[1] = "Graveyard";
            choicesList[2] = "Castle";
        }
    }
}
