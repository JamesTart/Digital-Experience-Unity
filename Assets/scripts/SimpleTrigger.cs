using UnityEngine;
using UnityEngine.Events;

public class simpleTrigger : MonoBehaviour
{
    public bool DestroyOnTrigger;
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent ontTriggerExit;


    void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag(tagFilter))
        {
            onTriggerEnter.Invoke();

            if (DestroyOnTrigger)
                Destroy(gameObject);
        }
        
            
        
    }
}
