using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_script : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    public float MaxHealth;
    

    private void Start()
    {
        //find
        HealthBar = GetComponent<Image>();
        
    }

    private void Update()
    {
        
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
