using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class LookAtAnimationRigging : MonoBehaviour
{
    private Rig rig;
    private float targetWeight;
    [SerializeField] private Slider slider;

    void Awake()
    {
        rig = GetComponent<Rig>();
    }
    void Update()
    {
        rig.weight = Mathf.Lerp(rig.weight, targetWeight, Time.deltaTime * 10f);
        rig.weight = slider.value;
        /*if (Input.GetKeyDown(KeyCode.T))
        {
            targetWeight = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            targetWeight = 0f;
        }*/
    }
}
