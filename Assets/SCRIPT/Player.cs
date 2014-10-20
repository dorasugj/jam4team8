using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public int JUMP_LIMIT;
    public float JUMP_SPEED;

    private int _jumpCount;

    public AudioClip audioClip;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -2.0f) transform.position += Vector3.right * 0.2f * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Return) && _jumpCount<JUMP_LIMIT)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, JUMP_SPEED, 0.0f);
            _jumpCount++;
            audioSource.PlayOneShot(audioClip); // ジャンプSE
        }

        // 画面外判定
        if (gameObject.transform.position.y <= -4.0f || gameObject.transform.position.x <= -4.6)
        {
            GameObject.FindObjectOfType<GameManager>().EndMessage(); //画面外に出たので終了を要求
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "ground")
        {
            _jumpCount = 0;
        }
    }
}
