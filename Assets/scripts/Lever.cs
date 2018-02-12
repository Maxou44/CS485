using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    private Animator animator;

    public Trap trap;

    public bool activate = false;

    public bool playerCollision = false;

    // Detect collision with player
    void OnTriggerEnter2D(Collider2D obj)
    {
        playerCollision = true;
    }

    //Detect end of collision with player
    void OnTriggerExit2D(Collider2D obj)
    {
        playerCollision = false;
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollision && Input.GetButtonDown("ActionKey") && !activate)
        {
			activate = true;
            trap.Disable();
            animator.SetBool("activate", true);
			return;
        }
        
		if (playerCollision && Input.GetButtonDown("ActionKey") && activate)
        {
			activate = false;
            trap.Enable();
            animator.SetBool("activate", false);
			return;
        }
    }
}
