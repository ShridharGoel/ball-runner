using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;

	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        transform.Translate(Input.acceleration.x * 0.92f, 0, 0);

        if(transform.position.y<0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}