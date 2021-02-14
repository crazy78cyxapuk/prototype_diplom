using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speedRotate;

    void Update()
    {
        transform.Rotate(0, speedRotate, 0);
    }
}
