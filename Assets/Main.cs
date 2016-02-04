using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public GameObject tank;
	public GameObject bulletPrefab;

	public float speed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			tank.transform.Translate(Vector3.right  * (speed));
		}

		if (Input.GetKey (KeyCode.A)) {
			tank.transform.Translate(Vector3.left  * (speed));
		}

		if (Input.GetKey (KeyCode.W)) {
			tank.transform.Translate(Vector3.up * (speed));
		}

		if (Input.GetKey (KeyCode.S)) {
			tank.transform.Translate(Vector3.down * (speed));
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject bullet = (GameObject)Instantiate(bulletPrefab);
			bullet.GetComponent<BullectMove>().ID = 0;
			bullet.GetComponent<Transform>().position = tank.transform.position;
		}
	}
}
