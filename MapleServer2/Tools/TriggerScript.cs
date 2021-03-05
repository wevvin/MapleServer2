using System;
using Maple2.Trigger;

namespace MapleServer2.Tools
{
    public class TriggerScript
    {
        private readonly TriggerContext Context;

        private TriggerState State;
        private TriggerState NextState;

        public TriggerScript(TriggerContext context, TriggerState start)
        {
            this.Context = context;
            this.NextState = start;
        }

        public void Next()
        {
            if (Environment.TickCount < Context.NextTick)
            {
                return;
            }
            
            Context.NextTick = Environment.TickCount + Context.TickDelay;

            if (NextState != null)
            {
                State?.OnExit();
                State = NextState;
                State.OnEnter();
                NextState = null;
            }

            NextState = State.Execute();
        }
    }
}
