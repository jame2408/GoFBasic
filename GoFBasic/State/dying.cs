using System;

namespace GoFBasic.State
{
    public class Dying : IAgentState
    {
        public void heal(AgentV2 aAgent)
        {
            if (aAgent.getHP() >= AgentV2.HEALTH_LOW_LIMIT)
            {
                aAgent.changeState(AgentV2.Health_STATE);
            }
            else if (aAgent.getHP() >= AgentV2.INJURED_LOW_LIMIT)
            {
                aAgent.changeState(AgentV2.Injured_STATE);
            }
            
        }

        public void hitted(AgentV2 aAgent)
        {
            if (aAgent.getHP() == AgentV2.DEAD_LOW_LIMIT)
            {
                aAgent.changeState(AgentV2.Dead_STATE);
            }
        }

        public void fight(AgentV2 agentV2)
        {
            // Do something
        }

        public void search(AgentV2 agentV2)
        {
            // Do something
        }
    }
}