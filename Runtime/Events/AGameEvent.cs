using System;
using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    public abstract class AGameEvent<T> : ScriptableObject
    {
        // private readonly List<IGameEventListener<T>> eventListeners = new List<IGameEventListener<T>>();
        public event Action<T> eventListeners = delegate {};

        public void Raise(T item)
        {
            // for (int i = eventListeners.Count - 1; i >= 0; i--)
            // {
            //     eventListeners[i].OnEventRaised(item);
                
            // }
            eventListeners(item);
        }

        // public void RegisterListener(IGameEventListener<T> listener)
        // {
        //     if (!eventListeners.Contains(listener))
        //     {
        //         eventListeners.Add(listener);
        //     }
        // }

        // public void UnregisterListener(IGameEventListener<T> listener)
        // {
        //     if (eventListeners.Contains(listener))
        //     {
        //         eventListeners.Remove(listener);
        //     }
        // }

    }
}