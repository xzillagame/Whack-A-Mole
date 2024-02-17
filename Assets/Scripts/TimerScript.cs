using System;
using UnityEngine.Events;
using UnityEngine;
using System.Runtime.CompilerServices;

public class TimeIntervalComponentScript : MonoBehaviour
{

    [SerializeField]
    [Range(0.1f, 20)]
    [Tooltip("Counted in Seconds")]
    private float timePerInterval = 1f;

    [SerializeField] private float minimumTimeIntervalValue = 0.5f;


    private float elapsed_Time = 0;
    private const float timePerIntervalConst = 1f;
    


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


    public void SetTimeInterval(float newTimeInterval)
    {
        timePerInterval = newTimeInterval;
    }

    public void RestTimerToDefaultInterval()
    {
        timePerInterval = timePerIntervalConst;
    }


    public void DecreaseTimerInterval(float rateToDecreaseTimeInterval)
    {
        timePerInterval -= rateToDecreaseTimeInterval;

        if(timePerInterval <= minimumTimeIntervalValue)
        {
            timePerInterval = minimumTimeIntervalValue;
        }
    }


}
