using UnityEngine;
using UnityEngine.Events;

namespace craztad.ScriptableObjectHelper.Events
{
    [System.Serializable] public class UnityBoolEvent : UnityEvent<bool> { }

    [System.Serializable] public class UnityByteEvent : UnityEvent<byte> { }

    [System.Serializable] public class UnityCameraEvent : UnityEvent<Camera> { }

    [System.Serializable] public class UnityDoubleEvent : UnityEvent<double> { }

    [System.Serializable] public class UnityFloatEvent : UnityEvent<float> { }

    [System.Serializable] public class UnityGameObjectEvent : UnityEvent<GameObject> { }

    [System.Serializable] public class UnityIntEvent : UnityEvent<int> { }

    [System.Serializable] public class UnityLongEvent : UnityEvent<long> { }

    [System.Serializable] public class UnityRigidbodyEvent : UnityEvent<Rigidbody> { }

    [System.Serializable] public class UnityRigidbody2DEvent : UnityEvent<Rigidbody2D> { }

    [System.Serializable] public class UnityStringEvent : UnityEvent<string> { }

    [System.Serializable] public class UnityTransformEvent : UnityEvent<Transform> { }

    [System.Serializable] public class UnityVector2Event : UnityEvent<Vector2> { }

    [System.Serializable] public class UnityVector3Event : UnityEvent<Vector3> { }

    [System.Serializable] public class UnityVoidEvent : UnityEvent<Void> { }

    [System.Serializable] public class UnityQuaternionEvent : UnityEvent<Quaternion> { }
}