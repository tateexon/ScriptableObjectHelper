using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    [CreateAssetMenu(fileName = "New Bool Event", menuName = "Game Events/Bool Event")]
    public class BoolEvent : AGameEvent<bool> { }

    [CreateAssetMenu(fileName = "New Byte Event", menuName = "Game Events/Byte Event")]
    public class ByteEvent : AGameEvent<byte> { }

    [CreateAssetMenu(fileName = "New Camera Event", menuName = "Game Events/Camera Event")]
    public class CameraEvent : AGameEvent<Camera> { }

    [CreateAssetMenu(fileName = "New Double Event", menuName = "Game Events/Double Event")]
    public class DoubleEvent : AGameEvent<double> { }

    [CreateAssetMenu(fileName = "New Float Event", menuName = "Game Events/Float Event")]
    public class FloatEvent : AGameEvent<float> { }

    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Game Events/GameObject Event")]
    public class GameObjectEvent : AGameEvent<GameObject> { }

    [CreateAssetMenu(fileName = "New Int Event", menuName = "Game Events/Int Event")]
    public class IntEvent : AGameEvent<int> { }

    [CreateAssetMenu(fileName = "New Long Event", menuName = "Game Events/Long Event")]
    public class LongEvent : AGameEvent<long> { }

    [CreateAssetMenu(fileName = "New Rigidbody Event", menuName = "Game Events/Rigidbody Event")]
    public class RigidbodyEvent : AGameEvent<Rigidbody> { }

    [CreateAssetMenu(fileName = "New Rigidbody2D Event", menuName = "Game Events/Rigidbody2D Event")]
    public class Rigidbody2DEvent : AGameEvent<Rigidbody2D> { }

    [CreateAssetMenu(fileName = "New String Event", menuName = "Game Events/String Event")]
    public class StringEvent : AGameEvent<string> { }

    [CreateAssetMenu(fileName = "New Transform Event", menuName = "Game Events/Transform Event")]
    public class TransformEvent : AGameEvent<Transform> { }

    [CreateAssetMenu(fileName = "New Vector2 Event", menuName = "Game Events/Vector2 Event")]
    public class Vector2Event : AGameEvent<Vector2> { }

    [CreateAssetMenu(fileName = "New Vector3 Event", menuName = "Game Events/Vector3 Event")]
    public class Vector3Event : AGameEvent<Vector3> { }

    [CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void Event")]
    public class VoidEvent : AGameEvent<Void> { public void Raise() => Raise(new Void()); }

    [CreateAssetMenu(fileName = "New Quaternion Event", menuName = "Game Events/Quaternion Event")]
    public class QuaternionEvent : AGameEvent<Quaternion> { }
}