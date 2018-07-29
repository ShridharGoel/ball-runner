using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
	
	// Update is called once per frame
	void Update () {

        if(GameManager.gameHasEnded==false)
        score.text = (player.position.z).ToString("0");
		
	}
}
