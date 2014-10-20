using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public int SPEED;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * SPEED * Time.deltaTime;
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
