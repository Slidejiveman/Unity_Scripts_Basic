using System;

public class InfoEventArgs<T> : EventArgs
{
    public T info;

    /// <summary>
    /// The default method in this constructor will
    /// return the default value for whatever type is 
    /// passed in. That could be 0 for an int, or null
    /// for a GameObject.
    /// </summary>
    public InfoEventArgs()
    {
        info = default(T);
    }

    /// <summary>
    /// The non-default constructor acts as a setter.
    /// </summary>
    /// <param name="info"></param>
    public InfoEventArgs(T info)
    {
        this.info = info;
    }
	
}
