using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Hatch : MonoBehaviour
{
    [SerializeField] private float angle = 0f;
    [SerializeField] private float openTime = .5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            transform.DORotate(new Vector3(0, 0, angle), openTime);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            transform.DORotate(new Vector3(0, 0, 0), openTime);
    }
}
