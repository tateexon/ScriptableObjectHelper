using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    [CreateAssetMenu(fileName = "New Camera Event", menuName = "Game Events/Camera Event")]
    public class CameraEvent : AGameEvent<Camera> { }
}