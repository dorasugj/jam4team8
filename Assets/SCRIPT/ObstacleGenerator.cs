using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour {
    public GameObject desk;
    public GameObject light;
    public GameObject tobibako;

    private float _passTime;
    private float _oldTime;

	// Use this for initialization
	void Start () {
        _passTime = _oldTime = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        _passTime += Time.deltaTime;

        if(Time.time-_oldTime>3.0f*(1.0f-_passTime*0.01f)){
            var kind=Random.Range(0,3);

            if(kind==0){
                Instantiate(desk);
            }
            else if (kind == 1)
            {
                Instantiate(light);
            }
            else if (kind == 2)
            {
                Instantiate(tobibako);
            }

            _oldTime=Time.time;
        }
	}
}
