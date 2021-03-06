﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineCore.Lib
{
    public sealed class SwitchStopEffect : Effect
    {
        public static SwitchStopEffect Instance { get; private set; } = new SwitchStopEffect();

        public SwitchStopEffect() : base("Switch Stop Effect")
        {
        }

        protected override void ExecuteAction(StateMachine context)
        {
            var stm = context.GetAs<ModelStateMachine>();

            var model = stm.Model;

            model.Stop();
        }
    }
}
