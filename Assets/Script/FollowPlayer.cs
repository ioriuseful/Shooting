﻿using UnityEngine;
using System.Collections;
public class FollowPlayer: MonoBehaviour{
public Transform target;
private Vector3 offset;
// Use this for initialization
void Start()
{
    offset = transform.position - target.position;
}
// Update is called once per frame
void Update()
{
    this.transform.position = target.position + offset;
}
}