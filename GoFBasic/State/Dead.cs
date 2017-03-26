using System;

namespace GoFBasic.State
{
    public class Dead : IAgentState
    {
        public void heal(AgentV2 aAgent)
        {
            // resurrection
        }

        public void hitted(AgentV2 aAgent)
        {
            // Do something, I am already dead.
        }
    }
}