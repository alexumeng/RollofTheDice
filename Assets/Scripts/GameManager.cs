using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // prep screen --> rolling dice
    // inside level
    // fight
    // player turn
    // enemy turn
    // victory
    // lose

    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        //UpdateGameState(Prep);
    }

    // Update is called once per frame
    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Prep:
                
                break;
            case GameState.MissionSelect:
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;
        }

        OnGameStateChanged?.Invoke(newState);

    }
}

public enum GameState
{
    Prep,
    MissionSelect,
    PlayerTurn,
    EnemyTurn,
    Victory,
    Lose
}
