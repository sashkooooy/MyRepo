﻿using Exam_20_12._15.Enums;

namespace Exam_20_12._15.Interfaces
{
    public interface IAttack
    {
        BlobAttackType attackType { get; }
        int AttackPerRound { get; }
    }
}