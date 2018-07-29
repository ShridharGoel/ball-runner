using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPressingBackButton : MonoBehaviour
{

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name != "FirstScene")
            {
                SceneManager.LoadScene("FirstScene");
                GameManager.gameHasEnded = true;
            }

            else
                Application.Quit();

        }
    }
	
}
