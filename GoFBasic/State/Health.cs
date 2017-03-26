using System;

namespace GoFBasic.State
{
    public class Health : IAgentState
    {
        public void hitted(AgentV2 aAgent)
        {
            if (aAgent.getHP() < AgentV2.HEALTH_LOW_LIMIT)
            {
                //aAgent.changeState(new Injured());
                aAgent.changeState(AgentV2.Injured_STATE);
            }
            if (aAgent.getHP() < AgentV2.INJURED_LOW_LIMIT)
            {
                //aAgent.changeState(new Dead());
                aAgent.changeState(AgentV2.Dead_STATE);
            }
        }

        public void heal(AgentV2 aAgent)
        {
            // Similar to hit
        }
    }
}