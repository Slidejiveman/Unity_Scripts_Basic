using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class give examples of how to write methods using Unity.
/// Here are some of the "template" methods that are a part of MonoBehavior
/// that are particularly useful:
/// 1. "Awake": called immediatelly following the instantiation of an object.
///             It is the earliest that somethign can be done to an object. Called once!
/// 2. "OnEnable": called after Awake. Often used to register event listeners.
///                Called every time the objects "enabled" state changes.
/// 3. "OnDisable": Used to remove event listeners from objects.
/// 4. "Start": called before the first frame "Update" method (after all objects have run
///             their Awake and OnEnable methods) as long as the object is enabled. 
///             Also good for initialization. Called once!
/// 5. "Update": is called once per frame at a variable time interval, and provdes a 
///              convenient handle to the "game loop". 
/// 6. "FixedUpdate": similar to update, but runs at a fixed time interval and is used
///                   to interact with physics.
/// 7. "LateUpdate": called after Update has finished and provides an option to have logic
///                  to respond to other changes that have happened.
/// 8. "OnDestroy": is called when you remove a GameObject from the scene. It is called once,
///                 and is a good place to clean up anything which was created during init.
/// </summary>
public class Methods : MonoBehaviour {

    public string test;
    public int value1, value2;

	void DoStuff()
    {
        Debug.Log("Hello World");
    }

    public bool IsRegistered(string myID)
    {
        return string.Equals(myID, "Jon");
    }

    private int Multiply(int a, int b)
    {
        return a * b;
    }
    
    // Use this for initialization
	void Start () {
        DoStuff();
        if(IsRegistered(test))
        {
            Debug.Log("Registered");
        }
        else
        {
            Debug.Log("Not Registered");
        }

        int value = Multiply(value1, value2);
        Debug.Log("Multiplication result: " + value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
