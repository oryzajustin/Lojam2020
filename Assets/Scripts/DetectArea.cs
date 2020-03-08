﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DetectArea : MonoBehaviourPun
{
    [SerializeField] Transform itemSlot;
    [SerializeField] PlayableCharacter selfCharacter;
    private void OnTriggerStay(Collider other)
    {
        selfCharacter.CheckPickUp(other);
    }
}
