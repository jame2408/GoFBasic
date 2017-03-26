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
                //aAgent.changeState(new Health());
                aAgent.changeState(AgentV2.Health_STATE);
            }
            else if (aAgent.getHP() >= AgentV2.INJURED_LOW_LIMIT)
            {
                //aAgent.changeState(new Injured());
                aAgent.changeState(AgentV2.Injured_STATE);
            }
        }

        public void hitted(AgentV2 aAgent)
        {
            // Do something, I am already dead.
        }
    }
}