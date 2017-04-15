namespace GoFBasic.State
{
    public class Injured : IAgentState
    {
        public void hitted(AgentV2 aAgent)
        {
            if (aAgent.getHP() == AgentV2.DEAD_LOW_LIMIT)
            {
                //aAgent.changeState(new Dead());
                aAgent.changeState(AgentV2.Dead_STATE);
            }
        }

        public void heal(AgentV2 aAgent)
        {
            if (aAgent.getHP() >= AgentV2.HEALTH_LOW_LIMIT)
            {
                //aAgent.changeState(new Health());
                aAgent.changeState(AgentV2.Health_STATE);
            }

            // Do something.
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