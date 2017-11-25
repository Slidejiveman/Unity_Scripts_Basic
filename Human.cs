using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    public int age = 23;
    public string FavoriteMove { get; private set; } // This is a property. Usually used to control
    public GameObject friend;
    public bool IsFriend
    {
        get // has to have either get or set, but not both
        {
            return friend != null; // can specifically set the "backing value"
        } 
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Hello, my name is " + name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
