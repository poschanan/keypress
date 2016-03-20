using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class press : MonoBehaviour {
	public Text txtPress;
	public int count = 0;

	void Start () {
	
	}

	void Update () {
		if (Input.anyKeyDown) {
			count++;
			txtPress.text = "P R E S S : " + count;
		}
	}
}
