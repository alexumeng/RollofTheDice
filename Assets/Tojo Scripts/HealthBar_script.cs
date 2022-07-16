using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_script : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    WolfVariables_Script Wolves;

    private void Start()
    {
        //find
        HealthBar = GetComponent<Image>();
        Wolves = FindObjectOfType<WolfVariables_Script>();
    }

    private void Update()
    {
        CurrentHealth = Wolves.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
