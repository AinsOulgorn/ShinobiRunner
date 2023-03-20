using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationGroundSpeed : MonoBehaviour
{

    private Animator _animator;
   
    private void OnEnable()
    {
        EventBus.Complication += SpeedAnimation;
    }


    private void OnDisable()
    {
        EventBus.Complication -= SpeedAnimation;
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }




    private void SpeedAnimation()
    {
        Debug.Log("Speed");

        _animator.speed += 0.2f;
    }





}
