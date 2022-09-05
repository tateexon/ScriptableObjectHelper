using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New String Event", menuName = "Game Events/String Event")]
    public class StringEvent : AGameEvent<string> { }
}