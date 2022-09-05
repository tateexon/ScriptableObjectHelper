namespace Craztad.ScriptableObjectHelper
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}