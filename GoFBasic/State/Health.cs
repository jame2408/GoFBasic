using System;

namespace GoFBasic.State
{
    public class Health : IAgentState
    {
        public void hitted(AgentV2 aAgent)
        {
            if (aAgent.getHP() < AgentV2.INJURED_LOW_LIMIT)
            {
                //aAgent.changeState(new Dead());
                aAgent.changeState(AgentV2.Dead_STATE);
            }
            else if (aAgent.getHP() < AgentV2.HEALTH_LOW_LIMIT)
            {
                //aAgent.changeState(new Injured());
                aAgent.changeState(AgentV2.Injured_STATE);
            }
            
        }

        public void heal(AgentV2 aAgent)
        {
            // Similar to hit
        }

        public void search(AgentV2 aAgent)
        {
            // DO something
        }

        public void fight(AgentV2 agentV2)
        {
            // Do something
        }
    }
}