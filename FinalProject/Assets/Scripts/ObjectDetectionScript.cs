using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		Debug.Log("Collision detected.");
		if(col.gameObject.tag == "AmmoObject")
		{
			Destroy(col.gameObject);
			//GameObject.Find("AmmoAmount").guiText = "60/60";
			Debug.Log("Refill Ammo.");
		}else if((col.gameObject.tag == "HealthObject"))
		{
			//GameObject.Find("HealthAmount").guiText.text = "100/100";
			Debug.Log("Refill Health.");
		}
		Destroy(col.gameObject);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
