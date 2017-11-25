using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExamples : MonoBehaviour {

    // Unity does not recognize Dictionaries, so even though this is 
    // public, it will not be serialized. You can't use editor based
    // initialization. Scripts can access them still.
    public Dictionary<string, int> stats = new Dictionary<string, int>();
	
    // Use this for initialization
	void Start () {
        // you will get an error if you try to add something to a 
        // dictionary that is a duplicate key.
        // dictionary[key] = value will change its value
        stats.Add("HP", 10);
        stats.Add("MP", 3);
        stats.Remove("MP");

        // when working with dictionaries, it is a good idea to 
        // test if a key is present before trying to use it
        if(stats.ContainsKey("HP"))
        {
            Debug.Log(string.Format("You have {0} hit points remaining", stats["HP"]));
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
