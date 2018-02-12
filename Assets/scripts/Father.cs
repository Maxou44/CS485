using UnityEngine;
using System.Collections;

public class Father : MonoBehaviour {

	public static Animator anim;
	public float speed = 8f;
    public Transform checkFloor;
    public LayerMask Floor;

    public bool colidFloor = false;
	float sizeFloor = 0.3f;
	

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		colidFloor = Physics2D.OverlapCircle(checkFloor.position, sizeFloor, Floor);
		anim.SetBool("floor", colidFloor);
	}
	
	// Detect collision
	/*void OnTriggerEnter2D(Collider2D other)
	{
		colidFloor = false;
		anim.SetBool("floor", false);
	}
	void OnTriggerExit2D(Collider2D other)
	{	
		colidFloor = false;
		anim.SetBool("floor", false);
	}*/
	
	// Update is called once per frame
	void Update ()
	{
		// Value of the X axis
		float x = Input.GetAxis ("Horizontal");
		anim.SetFloat ("speed", Mathf.Abs (x));
		
		// Go to right
		if (x > 0) {
			transform.Translate (x * speed * Time.deltaTime, 0, 0);
			transform.eulerAngles = new Vector2 (0,0);
		}
		
		// Go to left
		if (x < 0){
			transform.Translate (-x * speed * Time.deltaTime, 0, 0);
			transform.eulerAngles = new Vector2 (0,180);
		}

        // Jump
        if (colidFloor == true && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 225));
        }
    }
}
