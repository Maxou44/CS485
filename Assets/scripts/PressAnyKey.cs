using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PressAnyKey : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            if (SceneManager.GetActiveScene().buildIndex == 7)
                SceneManager.LoadScene(0);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
