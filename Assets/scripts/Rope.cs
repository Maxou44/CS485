using UnityEngine;
using System.Collections;

public class Rope : MonoBehaviour
{
    private Animator animator;

    public Trap trap;

    public bool activate = false;

    public bool playerCollision = false;

    // Detect collision with player
    void OnTriggerEnter2D(Collider2D obj)
    {
		if (obj.tag == "Player")
		{
			playerCollision = true;
		}
    }

    // Detect end of collision with player
    void OnTriggerExit2D(Collider2D obj)
    {
		if (obj.tag == "Player")
		{
			playerCollision = false;
		}
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollision && Input.GetButton("ActionKey"))
        {
			if (activate)
				return;
			activate = true;
            trap.Disable();
            animator.SetBool("activate", true);
        }
        else
        {
			if (!activate)
				return;
			activate = false;
            trap.Enable();
            animator.SetBool("activate", false);
        }
    }
}
