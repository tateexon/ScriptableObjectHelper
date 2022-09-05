using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    [CreateAssetMenu(fileName = "New Quaternion Event", menuName = "Game Events/Quaternion Event")]
    public class QuaternionEvent : AGameEvent<Quaternion> { }
}