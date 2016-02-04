using UnityEngine;
using System.Collections;

public class BullectMove : MonoBehaviour {

	private int longLife = 360;
	public int ID = 100;

	// Use this for initialization
	void Start () {
		longLife = 360;
	}
	
	// Update is called once per frame
	void Update () {

		if (longLife == 0 && ID == 0) {
			Destroy (this.gameObject);
			Debug.Log("Die");
			return ;
		}

		this.transform.Translate (Vector3.up * 0.1f);

		longLife--;
	}
	
}
