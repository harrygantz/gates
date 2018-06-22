using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    //Variables 
    public LevelManager _levelManager;
    public int points = 0;
    
    //Instantiation: We can be greedy here because this will certianly be used every time the game is launched
    private static GameManager _gameManager = new GameManager();
    
    //Constructors
    private GameManager() {}
    public static GameManager GM
    {
        get { return _gameManager; }
    }

    //Properties
    void InitGame()
    {

    }


    //Unity Mathods 
    void Awake ()
    {
        _levelManager = GetComponent<LevelManager>();
        InitGame();
	}
}
