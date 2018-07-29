using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public static bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject gameOverPanel;
    public GameObject levelCompletePanel;
    public GameObject nextLevelBtn;

    public void LevelComplete()
    {
        gameHasEnded = true;
        levelCompletePanel.SetActive(true);
        nextLevelBtn.SetActive(true);
    }

	public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            gameOverPanel.SetActive(true);
            Invoke("Restart", restartDelay);

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameHasEnded = false;
    }

}
