using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event Action<GameState> OnGameStateChanged;

    [Header("References")]
    [SerializeField] private EggCounterUI _eggCounterUI;

    [Header("Settings")]
    [SerializeField] private int _maxEggCount = 5;
    private int _currentEggCount;

    private GameState _currentGameState;

    private void Awake()
    {
        Instance = this;
    }

    void OnEnable()
    {
        ChangeGameState(GameState.Play);
    }

    public void ChangeGameState(GameState gameState)
    {
        OnGameStateChanged?.Invoke(gameState);
        _currentGameState = gameState;
        Debug.Log("Game State:" + gameState);
    }

    public void OnEggCollected()
    {
        _currentEggCount++;

        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);

        if (_currentEggCount == _maxEggCount)
        {
            //WIN
            Debug.Log("Game Win");
            _eggCounterUI.SetEggCompleted();
            ChangeGameState(GameState.GameOver);
        }
        Debug.Log("CurrentEgg:" + _currentEggCount);
    }

    public GameState GetCurrentState()
    {
        return _currentGameState;
    }
}
