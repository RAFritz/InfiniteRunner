using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {

	public float moveSpeed = 1f;

	public Transform player;
	public Animation anim;

	public Vector3 jump;
	public float jumpForce = 2.0f;

	public bool isGrounded;
	Rigidbody rb;

	public bool isDead = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		jump = new Vector3 (0.0f, jumpForce, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDead) {
			Move ();
			if (Input.GetKeyDown ("space") && isGrounded) {
				rb.AddForce (jump * jumpForce, ForceMode.Impulse);
				isGrounded = false;
			}
		} else {
			if(Input.GetKeyDown("space"))
				SceneManager.LoadScene("Scene1");
		}
	}

	void Move() {
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		anim.Play("Walk");
	}

	void OnCollisionStay() {
		isGrounded = true;
	}

	void Die() {
		isDead = true;
		anim.Play ("Default");
		transform.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		transform.Rotate (45f, 0f, 0f);
		//transform.position -= transform.up;
	}
}
