using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    public float SPEED;

    private GroundGenerator _groundGenerator;

	// Use this for initialization
	void Start () {
        _groundGenerator = GameObject.Find("GroundGenerator").GetComponent<GroundGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * SPEED * Time.deltaTime;

        if(transform.position.x<-5.3f){
            Destroy(gameObject);
            _groundGenerator.GroundGenerate();
        }
	}
}
