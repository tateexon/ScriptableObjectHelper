using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Game Events/GameObject Event")]
    public class GameObjectEvent : AGameEvent<GameObject> { }
}