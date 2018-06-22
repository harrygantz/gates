using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBee : MonoBehaviour {

    GameObject Bee;
    private bool movingRight;
    private bool colision;
    public float speed = 2.0f;

    private void Start ()
    {
        Bee = GetComponent<GameObject>();
        movingRight = true;
    }
	

	private void Update ()
    {
        if (movingRight)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(transform.position.x >= 12.0f)
        {
            Debug.Log("Points Should Increase");
            GameManager.Gm.SetPoints(1);
            Destroy(gameObject);
        }
	}

}
