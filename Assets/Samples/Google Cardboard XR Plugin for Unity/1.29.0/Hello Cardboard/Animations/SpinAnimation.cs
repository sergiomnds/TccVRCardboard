using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAnimation : MonoBehaviour
{
    public Animator ObjectAnimator;

    private const string StartTrigger = "TrStart";
    private const string StopTrigger = "TrStop";

    void Start()
    {
        if (ObjectAnimator == null)
        {
            ObjectAnimator = GetComponent<Animator>();
        }

        StopAnimation();
    }

    public void OnPointerEnter()
    {
        StartAnimation();
    }

    public void OnPointerExit()
    {
        StopAnimation();
    }

    private void StartAnimation()
    {
        if (ObjectAnimator != null)
        {
            ObjectAnimator.ResetTrigger(StopTrigger);
            ObjectAnimator.SetTrigger(StartTrigger);
        }
    }

    private void StopAnimation()
    {
        if (ObjectAnimator != null)
        {
            ObjectAnimator.ResetTrigger(StartTrigger);
            ObjectAnimator.SetTrigger(StopTrigger);
        }
    }

    void Update()
    {
        
    }
}
