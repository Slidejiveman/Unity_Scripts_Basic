using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour {

    public string[] responses;

    /// <summary>
    /// Serializing a field like this makes it available
    /// to the Unity Editor while keeping it private from
    /// other classes/scripts.
    /// </summary>
    [SerializeField]
    Text _label;

    /// <summary>
    /// This method is functioning as an event handler. On a 
    /// button press, we want to see a random response from the
    /// magic 8 ball.
    /// </summary>
    public void AskQuestion()
    {
        int index = UnityEngine.Random.Range(0, responses.Length);
        _label.text = responses[index];
    }
}
