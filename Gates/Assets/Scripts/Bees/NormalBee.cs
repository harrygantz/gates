using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBee : MonoBehaviour {

    GameObject Bee;
    GameManager _gameManager;
    private bool movingRight;
    private bool colision;
    public float speed = 2.0f;

    void Start ()
    {
        Bee = GetComponent<GameObject>();
        _gameManager = GameManager.GM;
	}
	

	void Update ()
    {
        if (movingRight)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(transform.position.x >= 12.0f)
        {
            _gameManager.points = _gameManager.points + 1;
        }
	}
}
