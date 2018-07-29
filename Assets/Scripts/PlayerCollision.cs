using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            playerMovement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }

        else if(collisionInfo.gameObject.tag == "LevelComplete")
        {
            FindObjectOfType<GameManager>().LevelComplete();
        }
    }

}
