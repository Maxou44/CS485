using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PressAnyKey : MonoBehaviour {

    bool lastStatus = false;

    // Use this for initialization
    void Start () {
        this.lastStatus = Input.anyKeyDown;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            if (this.lastStatus)
                return;
            if (SceneManager.GetActiveScene().buildIndex - 1 == SceneManager.sceneCount)
                SceneManager.LoadScene(0);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        this.lastStatus = Input.anyKeyDown;
    }
}
