using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FMODUnity.RuntimeManager.PlayOneShot("event:/TestSoundEvent");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
