using System;
using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    public abstract class AGameEvent<T> : ScriptableObject
    {
        public event Action<T> eventListeners = delegate { };

        public void Raise(T item)
        {
            eventListeners(item);
        }

    }
}