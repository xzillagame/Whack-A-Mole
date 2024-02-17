using System;
using UnityEngine.Events;
using UnityEngine;

public class TimeIntervalComponentScript : MonoBehaviour
{

    [SerializeField]
    [Range(0.1f, 20)]
    [Tooltip("Counted in Seconds")]
    private float timePerInterval = 1f;

    private float elapsed_Time = 0;


    [Serializable]
    public class TimerIntervalCompleted : UnityEvent { }
    public TimerIntervalCompleted onTimerComplete;


    
    // Update is called once per frame
    void Update()
    {
        elapsed_Time += Time.deltaTime;

        if (elapsed_Time >= timePerInterval)
        {
            elapsed_Time = 0;

            if (onTimerComplete != null)
            {
                onTimerComplete.Invoke();
            }
        }
    }

}
