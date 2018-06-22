using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    //Variables 
    public LevelManager _levelManager;
    private static int points;
    
    //Instantiation: We can be greedy here because this will certianly be used every time the game is launched
    private static GameManager _gameManager = new GameManager();
    
    //Constructors
    private GameManager() {}
    public static GameManager Gm
    {
        get { return _gameManager; }
    }

    //Properties
    private void InitGame()
    {

    }

    public void SetPoints(int p)
    {
        points += p;
    }

    public int GetPoints()
    {
        return points;
    }


    //Unity Mathods 
    private void Awake ()
    {
        _levelManager = GetComponent<LevelManager>();
        InitGame();
	}

    private void Update()
    {
        Debug.Log(points);
    }
}
