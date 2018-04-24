using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject gameOverUI;
    [HideInInspector]
    public static bool GameIsOver;

    private void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update () {
        if (GameIsOver)
        {
            return;
        }

		if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }
}
