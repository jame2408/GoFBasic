namespace GoFBasic.State
{
    public class Injured : IAgentState
    {
        public void hitted(AgentV2 aAgent)
        {
            throw new System.NotImplementedException();
        }

        public void heal(AgentV2 aAgent)
        {
            if (aAgent.getHP() >= AgentV2.HEALTH_LOW_LIMIT)
            {
                aAgent.changeState(new Health());
            }

            // Do something.
        }
    }
}