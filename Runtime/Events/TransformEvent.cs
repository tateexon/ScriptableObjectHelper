using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    [CreateAssetMenu(fileName = "New Transform Event", menuName = "Game Events/Transform Event")]
    public class TransformEvent : AGameEvent<Transform> { }
}