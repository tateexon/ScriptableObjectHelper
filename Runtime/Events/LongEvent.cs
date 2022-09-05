using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New Long Event", menuName = "Game Events/Long Event")]
    public class LongEvent : AGameEvent<long> { }
}