using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New Camera Event", menuName = "Game Events/Camera Event")]
    public class CameraEvent : AGameEvent<Camera> { }
}