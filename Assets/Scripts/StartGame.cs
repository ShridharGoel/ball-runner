using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void GameStart()
    {
        SceneManager.LoadScene("LevelSelectScene");
    }
	
}
