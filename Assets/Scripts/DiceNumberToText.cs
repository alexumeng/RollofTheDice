using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberToText : MonoBehaviour
{
    public Text text;
    public static int diceNumber;
    public static string diceOutcome;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = diceNumber.ToString();
        text.text = diceOutcome;
    }
}
