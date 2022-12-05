using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMover
{
    int Health { get; set; }
    bool IsPlayer { get; }
}
