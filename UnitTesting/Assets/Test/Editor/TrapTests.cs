using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;

public class TrapTests
{
    [Test]
    public void PlayerEnteringTrap_PlayerTargetedTrap_HealthAt0()
    {
        Trap trap = new Trap();
        IPlayerMover playerMover = Substitute.For<IPlayerMover>();
        playerMover.IsPlayer.Returns(true);
        trap.HandleCharacterEntered(playerMover, TrapTargetType.Player);

        Assert.AreEqual(0, playerMover.Health);
    }

    [Test]
    public void NpcEnteringTrap_NpcTargetedTrap_HealthAt0()
    {
        Trap trap = new Trap();
        IPlayerMover playerMover = Substitute.For<IPlayerMover>();
        trap.HandleCharacterEntered(playerMover, TrapTargetType.Npc);

        Assert.AreEqual(0, playerMover.Health);
    }

    [Test]
    public void NpcEnteringTrap_NpcTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        IPlayerMover playerMover = Substitute.For<IPlayerMover>();
        playerMover.Health = 1;
        trap.HandleCharacterEntered(playerMover, TrapTargetType.Npc);

        Assert.AreEqual(0, playerMover.Health);
    }

    [Test]
    public void PlayerEnteringTrap_PlayerTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        IPlayerMover playerMover = Substitute.For<IPlayerMover>();
        playerMover.IsPlayer.Returns(true);
        playerMover.Health = 1;
        trap.HandleCharacterEntered(playerMover, TrapTargetType.Player);

        Assert.AreEqual(0, playerMover.Health);
    }
}
