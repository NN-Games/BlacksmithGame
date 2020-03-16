using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Hatch : MonoBehaviour
{
    [SerializeField] private float angle = 0f;
    [SerializeField] private bool isVertical = false;
    [SerializeField] private float openTime = .5f;

    private Transform _hatch = null;
    private Quaternion _hatchRotation = Quaternion.identity;
    private void Awake()
    {
        _hatch = GetComponentInParent<MeshRenderer>().transform;
        _hatchRotation = _hatch.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(!isVertical)
                _hatch.transform.DORotate(new Vector3(_hatchRotation.x, _hatchRotation.y, angle), openTime);
            else
                _hatch.transform.DORotate(new Vector3(angle,_hatchRotation.y , _hatchRotation.z), openTime);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(!isVertical)
                _hatch.transform.DORotate(new Vector3(_hatchRotation.x, _hatchRotation.y, 0), openTime);
            else
                _hatch.transform.DORotate(new Vector3(0, _hatchRotation.y, _hatchRotation.z), openTime);
        }
    }
}
