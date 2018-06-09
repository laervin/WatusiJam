using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedofShotIndicator : MonoBehaviour {

	public float ChargeLevel = 0f;
	public int ChargeSpeed = 100;

	public GameObject firstSpeed;
	public GameObject secondSpeed;
	public GameObject thirdSpeed;
	public GameObject fourthSpeed;
	public GameObject fifthSpeed;

	public GameObject projectile;
	Rigidbody2D projectileRB; 

	// Use this for initialization
	void Start () {
		firstSpeed.SetActive (false);
		secondSpeed.SetActive (false);
		thirdSpeed.SetActive (false);
		fourthSpeed.SetActive (false);
		fifthSpeed.SetActive (false);

		projectileRB = projectile.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			ChargeLevel += Time.deltaTime * ChargeSpeed;
			if (ChargeLevel > 100 && ChargeLevel < 200) {				
				firstSpeed.SetActive (true);
			} else if (ChargeLevel > 200 && ChargeLevel < 300) {
				secondSpeed.SetActive (true);
			} else if (ChargeLevel > 300 && ChargeLevel < 400) {
				thirdSpeed.SetActive (true);
			} else if (ChargeLevel > 400 && ChargeLevel < 500) {
				fourthSpeed.SetActive (true);
			} else if (ChargeLevel > 500 && ChargeLevel < 600) {
				fifthSpeed.SetActive (true);
			} else if (ChargeLevel > 600 && ChargeLevel < 700) { //power level starting to go back down
				fifthSpeed.SetActive (false);
			} else if (ChargeLevel > 700 && ChargeLevel < 800) {
				fourthSpeed.SetActive (false);
			} else if (ChargeLevel > 800 && ChargeLevel < 900) {
				thirdSpeed.SetActive (false);
			} else if (ChargeLevel > 900 && ChargeLevel < 1000) {
				secondSpeed.SetActive (false);
				ChargeLevel = 100; //restarting to the first level of charge, no need to go back to 0 since they are still holding down
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (ChargeLevel > 100 && ChargeLevel < 200) {
				projectileRB.velocity = transform.right * 3;
				//projectileRB.velocity = transform.up * 2;
			} else if (ChargeLevel > 200 && ChargeLevel < 300) {
				projectileRB.velocity = transform.right * 8;
			} else if (ChargeLevel > 300 && ChargeLevel < 400) {
				projectileRB.velocity = transform.right * 10;
			} else if (ChargeLevel > 400 && ChargeLevel < 500) {
				projectileRB.velocity = transform.right * 15;
			} else if (ChargeLevel > 500 && ChargeLevel < 600) {
				projectileRB.velocity = transform.right * 25;
			} else if (ChargeLevel > 600 && ChargeLevel < 700) { //power level starting to go back down
				projectileRB.velocity = transform.right * 15;
			} else if (ChargeLevel > 700 && ChargeLevel < 800) {
				projectileRB.velocity = transform.right * 10;
			} else if (ChargeLevel > 800 && ChargeLevel < 900) {
				projectileRB.velocity = transform.right * 8;
			} else if (ChargeLevel > 900 && ChargeLevel < 1000) {
				projectileRB.velocity = transform.right * 3;
				ChargeLevel = 100; //restarting to the first level of charge, no need to go back to 0 since they are still holding down
			}
			
			ChargeLevel = 0f;
			firstSpeed.SetActive (false);
			secondSpeed.SetActive (false);
			thirdSpeed.SetActive (false);
			fourthSpeed.SetActive (false);
			fifthSpeed.SetActive (false);
		}
	}
}

