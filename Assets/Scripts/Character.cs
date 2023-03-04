using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected Flowchart chat = null;

    protected abstract void Talk();

}
