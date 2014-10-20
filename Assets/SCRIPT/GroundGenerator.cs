using UnityEngine;
using System.Collections;

public class GroundGenerator : MonoBehaviour {
    public GameObject _staris;
    public GameObject _ground;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 11; i++) {
            _ground.transform.position = new Vector3(-4.3f + i, -2.2f, 0.0f);
            Instantiate(_ground);
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void GroundGenerate()
    {
        var kind = Random.Range(0, 4);

        if (kind == 0)
        {
            _staris.transform.position = new Vector3(5.6f, -2.2f, 0.0f);
            Instantiate(_staris);
        }
        else
        {
            _ground.transform.position = new Vector3(5.6f, -2.2f, 0.0f);
            Instantiate(_ground);
        }
    }
}
