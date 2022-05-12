using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] ParticleSystem particlePrefab; // ParticleSystemのプレハブ(Inspectorで設定)
    private float speedZ = 0.05f; // スピード
     void OnTriggerEnter(Collider other)
    {
         Debug.Log("Hit!"); // デバッグ用にログ出力
        ParticleSystem ps = Instantiate(particlePrefab); // ParticleSystem（ps）を生成
        ps.transform.position = transform.position; // psを衝突した物体の位置に移動

        GameObject.Find ("Canvas").GetComponent<UIController> ().AddScore ();
        
        Destroy (other.gameObject);
		Destroy (gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speedZ); // 下に移動
        // 下のほうに消えていったらDestroy
        if (transform.position.z < -18)
        {
            Destroy(gameObject);
        }
    }
}
