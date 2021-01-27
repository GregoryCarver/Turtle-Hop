using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script keeps the name the same on the foreground and pipe clones.
public class DuplicateNaming : MonoBehaviour
{
    public string cloneName;

    void Awake()
    {
        this.name = cloneName;
    }
}
