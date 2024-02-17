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

    [SerializeField] private bool timerPaused = false;


    [Serializable]
    public class TimerIntervalCompleted : UnityEvent { }
    public TimerIntervalCompleted onTimerComplete;



    // Update is called once per frame
    void Update()
    {
        if (timerPaused == true)
        {
            return;
        }

        elapsed_Time += Time.deltaTime;

        if (elapsed_Time >= timePerInterval)
        {
            if (onTimerComplete != null)
            {
                onTimerComplete.Invoke();
            }
        }
    }

}
