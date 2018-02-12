using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Trap : MonoBehaviour
{
    private Animator animator;
	private bool collision;

    public bool activate = true;
    
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Disable()
    {
        if (activate == false)
            return;
        activate = false;
        animator.SetBool("activate", false);
    }

    public void Enable()
    {
        if (activate == true)
            return;
        activate = true;
        animator.SetBool("activate", true);
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Baby")
		{
			collision = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Baby")
		{
			collision = false;
		}
	}
	
    // Update is called once per frame
    void Update()
    {
		if (collision && activate)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}
