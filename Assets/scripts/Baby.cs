using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Baby : MonoBehaviour
{	
	public float speed = 8f;

	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{		
		// Move baby
		Move();
		
		// End of level
		if (transform.position.x > 6)
		{
			if (SceneManager.GetActiveScene().buildIndex >= 4)
				SceneManager.LoadScene(0);
			else
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		
	}

    // Move the baby
	void Move()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}