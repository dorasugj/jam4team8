using UnityEngine;
using System.Collections;

public class BackMove1 : MonoBehaviour
{
    public float SPEED;


    private GameObject _otherBackGround;

	// Use this for initialization
	void Start () {
        _otherBackGround = GameObject.Find("background2");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * SPEED * Time.deltaTime;

        if (transform.position.x < -9.6f) transform.position = _otherBackGround.transform.position + new Vector3(9.6f, 0.0f, 0.0f);
	}
}
