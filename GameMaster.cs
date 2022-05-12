using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject enemy; // 後ほど、BlockerプレハブをInspectorで割り当てる
    float elapsedTime = 0.0f; // 経過時間（前回の処理から何秒経ったのか？）
    float limitTime = 1.0f; // リミット時間（何秒後に処理を行うかを定義）
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // 経過時間にフレーム間の時間を加算
        if (elapsedTime > limitTime) // 経過時間がリミット時間を超えたら処理する
        {
            elapsedTime = 0; // 経過時間をゼロクリア
            GameObject obj = Instantiate(enemy); // プレハブから生成
            float x = Random.Range(-15, 15); // X座標（横位置）をランダムに
            obj.transform.position = new Vector3(x, 5, 17); // Positionを設定
        }
    }
}
