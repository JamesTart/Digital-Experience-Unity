using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    public bool closed = true;
    public float openDegrees = 90f;
    public float openSpeed = 60f;

    // Private Variables
    float closedDegreees;

    Vector3 closedEulerAngles;
    Vector3 openedEulerAngles;
    
    void Start()
    {
        closedDegreees = transform.localEulerAngles.y;

        closedEulerAngles = new Vector3(0f, closedDegreees, 0f);
        openedEulerAngles = new Vector3(0f, closedDegreees + openDegrees, 0f);
    }

    
    void Update()
    {
        if (closed)
            transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, closedEulerAngles, openSpeed * Time.deltaTime);
        else
            transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, openedEulerAngles, openSpeed * Time.deltaTime);
    }

    public void ToggleOpen()
    {
        closed = !closed;
    }
}
