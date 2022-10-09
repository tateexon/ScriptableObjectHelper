using UnityEngine;

namespace Craztad.ScriptableObjectHelper
{
    public class JsonSerializableScriptableObject : ScriptableObject
    {
        public string ToJson(bool prettyPrint = false)
        {
            return JsonUtility.ToJson(this, prettyPrint);
        }

        public void FromJson(string json)
        {
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}