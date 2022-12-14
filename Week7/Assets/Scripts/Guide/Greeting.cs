using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting : MonoBehaviour
{
    [SerializeField] private GameObject _guideController;
    [SerializeField] private Animator _guideAnimator;

    [SerializeField] private float _guidingTime = 5f;

    public bool _greeting = false;
  //  [SerializeField] private float _greetingTime = 0f;

    private void Awake()
    {
        _guideController.SetActive(false);
    }

    void Start()
    {
        _guideAnimator.SetTrigger("Salute");
        _greeting = true;
        Invoke("StartGuiding", _guidingTime);
        
    }


    void StartGuiding()
    {
        Debug.Log("start animating");
        _guideController.SetActive(true);
        _greeting = false;
    }
}
