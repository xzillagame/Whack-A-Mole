using System;
using UnityEngine.Events;
using UnityEngine;
using System.Runtime.CompilerServices;

public class TimeIntervalComponentScript : MonoBehaviour
{
  #region Time Interval Varaibles
        [SerializeField]
        [Range(0.1f, 20)]
        [Tooltip("Counted in Seconds")]
        private float timePerInterval = 1f;

        [SerializeField] private float minimumTimeIntervalValue = 0.5f;

        private const float timePerIntervalConst = 1f;
  #endregion

    private float elapsed_Time = 0;
    

    //Event for when elasped time has been reached.
    [Serializable]
    public class TimerIntervalCompleted : UnityEvent { }
    public TimerIntervalCompleted onTimerComplete;


   
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


    //SetTimeInterval called from Score Manager OnEvery10Point Event
    public void DecreaseTimerInterval(float rateToDecreaseTimeInterval)
    {
        timePerInterval -= rateToDecreaseTimeInterval;

        if(timePerInterval <= minimumTimeIntervalValue)
        {
            timePerInterval = minimumTimeIntervalValue;
        }
    }


}
