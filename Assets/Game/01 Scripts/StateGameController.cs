using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateGame
{
    Playing,
    Pause,
    Win,
    Checking,
}

public class StateGameController : MonoBehaviour
{
    public StateGame stateGame;

    void ChangeState(StateGame stateGame)
    {
        this.stateGame = stateGame;
    }

    public void Playing()
    {
        this.stateGame = StateGame.Playing;
    }

    public void Pause()
    {
        this.stateGame = StateGame.Pause;
    }

    public void Win()
    {
        this.stateGame = StateGame.Win;
    }

    public void Checking()
    {
        this.stateGame = StateGame.Checking;
    }
}
