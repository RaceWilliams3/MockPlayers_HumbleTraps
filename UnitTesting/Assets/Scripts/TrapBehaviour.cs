using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    [SerializeField]
    private TrapTargetType trapType;

    private Trap trap;

    void Awake()
    {
        trap = new Trap();
    }

    void OnTriggerEnter(Collider other)
    {
        var playerMover = other.GetComponent<IPlayerMover>();
        trap.HandleCharacterEntered(playerMover, trapType);
    }
}

public class Trap
{
    public void HandleCharacterEntered(IPlayerMover playerMover, TrapTargetType trapTargetType)
    {
        if (playerMover.IsPlayer)
        {
            if (trapTargetType == TrapTargetType.Player)
            {
                if (playerMover.Health > 0)
                {
                    playerMover.Health--;
                }
            }
        } 
        else
        {
            if (trapTargetType == TrapTargetType.Npc)
            {
                if (playerMover.Health > 0)
                {
                    playerMover.Health--;
                }
            }
        }
    }
}

public enum TrapTargetType { Player, Npc}