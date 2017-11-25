using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExamples : MonoBehaviour {

    // declare an empty list
    public List<int> indices = new List<int>();
	
    // Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++)
        {
            int index = UnityEngine.Random.Range(0, 10);
            Debug.Log("Adding Entry: " + index);
            indices.Add(index);
        }

        if (indices.Contains(3))
        {
            Debug.Log("Removing entry");
            indices.Remove(3); // removes only the first entry
        }

        indices.Sort();
        Debug.Log("Sorted entries... Now:");

        for (int i = 0; i < indices.Count; i++)
        {
            int index = indices[i];
            Debug.Log(string.Format("i: " + index));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
