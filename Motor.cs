using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {

    /// <summary>
    /// Speed in degrees per second.
    /// Assigning the value 360 would make the
    /// device perform a complete rotation in one second.
    /// 
    /// It is not initialized here because it is assumed it will
    /// be given a value in the editor or by another script.
    /// </summary>
    public float turnRate;
	
	// Update is called once per frame
    ///
    /// this allows incremental modification of GameObjects.
    /// Vector3 is a struct. It's constructor has X, Y, and Z params.
    /// 
	void Update () {
        transform.Rotate(new Vector3(0, turnRate * Time.deltaTime, 0));
	}
}
