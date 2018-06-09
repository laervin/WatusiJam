using UnityEngine;
using System.Collections;

public class chargeUpFollowMouse : MonoBehaviour {

	private Vector2 mousePosition;
	private Vector2 finalMousePosition;
	public float moveSpeed = 1f;
	public GameObject speedIndicator;

	// Use this for initialization
	void Start () {		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			mousePosition = Input.mousePosition;
			finalMousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = Vector2.Lerp (transform.position, finalMousePosition, moveSpeed);
		}
		if (Input.GetMouseButton (1)) {
			

		}
			//while (Input.GetMouseButtonUp(1))
			//{
			//scrollBar.SetActive (false);
			//}
	}
}