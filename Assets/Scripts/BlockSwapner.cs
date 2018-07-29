using UnityEngine;

public class BlockSwapner : MonoBehaviour {

    public Transform[] swapnPoints;
    public GameObject prefab;
    public float timeToSwapn = 2f;
    public float timeBetweenWaves = 1f;


	// Update is called once per frame
	void FixedUpdate () {


       // swapnPoints[i].position.z = transform.position.z + 5f;

       
            swapnBlocks();
            timeToSwapn = Time.time + timeBetweenWaves;
       
        
	}

    void swapnBlocks()
    {
        int randomNum = Random.Range(0, swapnPoints.Length);

        for (int i = 0; i < swapnPoints.Length; i++)
        {
            if (i != randomNum)
            {
                Instantiate(prefab, swapnPoints[i].position, Quaternion.identity);
            }
    
        }

    

        for (int i = 0; i < swapnPoints.Length; i++)
        {
            Vector3 temp = swapnPoints[i].position; // copy to an auxiliary variable...
            temp.z = temp.z + 20f; // modify the component you want in the variable...
            swapnPoints[i].position = temp; // and save the modified value 
        }
    }
}
