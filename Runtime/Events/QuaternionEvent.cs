using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New Quaternion Event", menuName = "Game Events/Quaternion Event")]
    public class QuaternionEvent : AGameEvent<Quaternion> { }
}