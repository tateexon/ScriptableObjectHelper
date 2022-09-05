using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Game Events/GameObject Event")]
    public class GameObjectEvent : AGameEvent<GameObject> { }
}