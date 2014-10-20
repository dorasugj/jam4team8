using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public float SPEED;
    private bool bEnd = false;
    public float fNextTime = 1.0f;
    // Use this for initialization
    void Start()
    {
        bEnd = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (bEnd == false)
        {
            GameObject.FindObjectOfType<Score>().ScoreUP(1); // スコアを常にアップ
        }
        else
        {
            fNextTime -= Time.deltaTime;
            if (fNextTime <= 0.0f)
            {
                GameObject.FindObjectOfType<Score>().Save();
                Application.LoadLevel("END"); // 経過時間後移動
            }

        }



    }

    // 終了判定
    public void EndMessage()
    {
        bEnd = true;
    }
}
