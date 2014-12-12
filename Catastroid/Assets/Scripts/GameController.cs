using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public static GameController controller;
    public static int MAX_HEALTH = 100;
    public static int BOSS_SCORE = 2000;
   
    #region Properties
    private int score = 20;
    public int Score
    {
        get { return score; }
        set { score += value; }
    }

    private int health = 20;
    public int Health
    {
        get { return health; }
        set { health += value; }
    }

    private bool dead;
    public bool Dead
    {
        get { return dead; }
        set { dead = value; }
    }

    private bool won;
    public bool Won
    {
        get { return won; }
        set { won = value; }
    }
    #endregion

    void Awake()
    {
        //if control is not set, set it to this one and allow it to persist
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;
        }
        //else if control exists and it isn't this instance, destroy this instance
        else if (controller != this)
        {
            //Debug.Log("Game control already exists, deleting this new one");
            Destroy(gameObject);
        }
    }

	void Start () 
    {
	
	}
	
	void Update () 
    {
        if (dead) ChangeLevel("GameOver");
        if (won) ChangeLevel("Win");
        if (Input.GetButtonDown("StartGame") && Application.loadedLevelName == "Menu") ChangeLevel("LevelOne");
        if (Input.GetButtonDown("Menu") && Application.loadedLevelName != "Menu") ChangeLevel("Menu");
        if (score >= BOSS_SCORE) ChangeLevel("Boss");
	}

    public void ChangeLevel(string nameOfLevel)
    {
        Application.LoadLevel(nameOfLevel);
    }
    
    public void StartGame()
    {
        Application.LoadLevel("LevelOne");
    }
}
