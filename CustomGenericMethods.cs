using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGenericMethods : MonoBehaviour {

    /// <summary>
    /// This method takes an component of an undefined time
    /// and toggles whether or not it is enabled.
    /// This should function as the checkboxes in the inspector.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	void ToggleComponent<T> () where T : MonoBehaviour
    {
        T t = gameObject.GetComponent<T>();
        if(t)
        {
            t.enabled = !t.enabled;
        }
    }

    /// <summary>
    /// This script will get the component of a given
    /// type as long as that component is attached to the 
    /// GameObject. If it is not attached, then the component
    /// is added to the object. This will ensure that the component
    /// is present.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    T FindOrAdd<T> () where T : MonoBehaviour
    {
        T t = gameObject.GetComponent<T>();
        if (t == null)
        {
            t = gameObject.AddComponent<T>();
        }
        return t;
    }
}
