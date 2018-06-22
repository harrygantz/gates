using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public int sceneNumber = 1;
    public float seconds = 0;
    private void Start()
    {
        StartCoroutine(WaitToLoadScene(seconds));
    }

    IEnumerator WaitToLoadScene(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(sceneNumber);
    }
}
