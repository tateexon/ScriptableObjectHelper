using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    [CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void Event")]
    public class VoidEvent : AGameEvent<Void> { public void Raise() => Raise(new Void()); }
}