using UnityEngine;

public class LocalObjectMover : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed = 10f;
    public bool smoothDamp;

    //private variables

    bool isNewPositionActive = false;
    Vector3 oldPosition;


    Vector3 targetPosition;

    Vector3 currentSpeed; // For SmoothDamp
    void Start()
    {
        oldPosition = transform.position;
        targetPosition = oldPosition;
    }

    void Update()
    {
        Vector3 currentPoistion = transform.position;

        if (smoothDamp)
            transform.position = Vector3.SmoothDamp(currentPoistion, targetPosition, ref currentSpeed, 2f / speed);
        else
            transform.position = Vector3.MoveTowards(currentPoistion, targetPosition, speed * Time.deltaTime);
    }

    public void MoveObject()
    {
        isNewPositionActive = !isNewPositionActive;


        if (isNewPositionActive)
            targetPosition = newPosition;

        else targetPosition = oldPosition;
    }
}