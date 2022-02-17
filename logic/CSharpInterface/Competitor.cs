﻿using System;

namespace CSharpInterface
{
    public partial class ClientInterface
    {
        private readonly ActiveSkillType activeSkillType = ActiveSkillType.NuclearWeapon;
        private readonly PassiveSkillType passiveSkillType = PassiveSkillType.RecoverAfterBattle;
        
        private void OperaionAtEachFrame()
        {
            MoveLeft(50);
            Attack(Math.PI / 4);
        }
    }
}
