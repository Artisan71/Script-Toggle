using UnityEngine;

public class ScriptEnableAndDisable : MonoBehaviour
{
    [Header("MADE BY ARTISAN71 PLS CREDIT IF YOU USE I SPENT -2 BUCKEROONIES ON THIS TO MAKE THIS EAT CHICKEN NUGGET")]
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
