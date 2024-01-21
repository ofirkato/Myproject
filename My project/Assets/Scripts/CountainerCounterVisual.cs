using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CountainerCounterVisual : MonoBehaviour
{
    private const string OPEN_CLOSE = "OpenClose";

    [SerializeField] private ContainerCounter containerCounter;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void start()
    {
        containerCounter.OnPlayerGrabbedObject += ContainerCounter_OnPlayerGrabbedObject;

    }

    private void ContainerCounter_OnPlayerGrabbedObject(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
