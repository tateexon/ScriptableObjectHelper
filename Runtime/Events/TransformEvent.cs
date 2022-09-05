using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New Transform Event", menuName = "Game Events/Transform Event")]
    public class TransformEvent : AGameEvent<Transform> { }
}