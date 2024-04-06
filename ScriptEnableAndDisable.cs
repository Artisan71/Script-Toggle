using UnityEngine;

public class ScriptEnableAndDisable : MonoBehaviour
{
    public string HandTag = "HandTag";
    public MonoBehaviour ObjectToDisableScript;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(HandTag))
        {
            ObjectToDisableScript.enabled = !ObjectToDisableScript.enabled;
        }
    }
}
