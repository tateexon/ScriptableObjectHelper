using UnityEngine;

namespace craztad.ScriptableObjectHelper.Events
{
    public class BoolListener : AGameEventListener<bool, BoolEvent, UnityBoolEvent> { }
    public class ByteListener : AGameEventListener<byte, ByteEvent, UnityByteEvent> { }
    public class CameraListener : AGameEventListener<Camera, CameraEvent, UnityCameraEvent> { }
    public class DoubleListener : AGameEventListener<double, DoubleEvent, UnityDoubleEvent> { }
    public class FloatListener : AGameEventListener<float, FloatEvent, UnityFloatEvent> { }
    public class GameObjectListener : AGameEventListener<GameObject, GameObjectEvent, UnityGameObjectEvent> { }
    public class IntListener : AGameEventListener<int, IntEvent, UnityIntEvent> { }
    public class LongListener : AGameEventListener<long, LongEvent, UnityLongEvent> { }
    public class RigidbodyListener : AGameEventListener<Rigidbody, RigidbodyEvent, UnityRigidbodyEvent> { }
    public class Rigidbody2DIntListener : AGameEventListener<Rigidbody2D, Rigidbody2DEvent, UnityRigidbody2DEvent> { }
    public class StringListener : AGameEventListener<string, StringEvent, UnityStringEvent> { }
    public class TransformListener : AGameEventListener<Transform, TransformEvent, UnityTransformEvent> { }
    public class Vector2Listener : AGameEventListener<Vector2, Vector2Event, UnityVector2Event> { }
    public class Vector3Listener : AGameEventListener<Vector3, Vector3Event, UnityVector3Event> { }
    public class VoidListener : AGameEventListener<Void, VoidEvent, UnityVoidEvent> { }
    public class QuaternionListener : AGameEventListener<Quaternion, QuaternionEvent, UnityQuaternionEvent> { }
}