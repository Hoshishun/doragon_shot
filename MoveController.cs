using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MoveController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public UnityEvent OnDestroyed = new UnityEvent();
    private void OnDestroy()
    {
        GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
        OnDestroyed.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        if (Input.GetKeyDown (KeyCode.Space)) 
        {
			Instantiate (bulletPrefab, transform.position, Quaternion.identity);
		}
    }
}
