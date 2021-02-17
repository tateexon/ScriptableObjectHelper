namespace craztad.ScriptableObjectHelper.Events
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}