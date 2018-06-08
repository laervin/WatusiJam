using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


	public GameObject rock;
	public Rigidbody2D rigidbody;
	public int speed;
	public int startingValue = 0;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
	}

	public void click()
	{
		
	}

	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(Vector2.right * speed);
		rigidbody.AddForce (Vector2.up * 200);

		if (rock.transform.position.x >= 50) {

			rigidbody.gravityScale = 10;
		}
		else if (rock.transform.position.x >= -25) {

			rigidbody.gravityScale = 8;
		}
			else
		if (rock.transform.position.x >= 0) {

			rigidbody.gravityScale = 4;
		}
			else	
		if (rock.transform.position.x >= -25) {

			rigidbody.gravityScale = 2;
		}

	}
}
