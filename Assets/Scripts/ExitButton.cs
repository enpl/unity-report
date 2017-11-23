using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {

    private GameObject exitBtn;

	// Use this for initialization
	void Start () {

	}

    public void Exit()
    {
        Application.Quit();
    }
	
	
}
