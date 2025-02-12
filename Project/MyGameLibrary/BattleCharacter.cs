﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public int Score { get; private set; }
        public int MaxScore { get; private set; }
        public float strength { get; private set; }
        public int MaxStrength { get; private set; }

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            MaxHealth = 20;
            MaxStrength = 4;
            strength = 2;
            Health = MaxHealth;
            MaxScore = 1000;
            Score = MaxScore;
        }

        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }

        public void AlterStrength(int amount)
        {
            strength += amount;
        }

        public void AlterScore(int amount)
        {
            Score += amount;
        }

    }
}
