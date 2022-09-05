using UnityEngine;
using UnityEngine.Events;

namespace craztad.ScriptableObjectHelper.Events
{
    public abstract class AGameEventListener<T, GE, UER> : MonoBehaviour, IGameEventListener<T> where GE : AGameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField] private GE gameEvent;
        public GE GameEvent
        {
            get { return gameEvent; }
            set { gameEvent = value; }
        }

        [SerializeField] private UER unityEventResponse;

        private void OnEnable()
        {
            if (gameEvent is null)
            {
                return;
            }
            gameEvent.eventListeners += OnEventRaised;
        }

        private void OnDisable()
        {
            if (gameEvent == null)
            {
                return;
            }
            gameEvent.eventListeners -= OnEventRaised;
        }

        public void OnEventRaised(T item)
        {
            // unity events may already do the null check for us
            // if (unityEventResponse != null)
            // {
            unityEventResponse.Invoke(item);
            // }
        }
    }
}