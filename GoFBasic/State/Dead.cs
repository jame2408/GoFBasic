using System;

namespace GoFBasic.State
{
    public class Dead : IAgentState
    {
        public void heal(AgentV2 aAgent)
        {
            // resurrection
            if (aAgent.getHP() >= AgentV2.HEALTH_LOW_LIMIT)
            {
                aAgent.changeState(new Health());
            }
            else if (aAgent.getHP() >= AgentV2.INJURED_LOW_LIMIT)
            {
                aAgent.changeState(new Injured());
            }
        }

        public void hitted(AgentV2 aAgent)
        {
            // Do something, I am already dead.
        }
    }
}