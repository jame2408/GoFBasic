namespace GoFBasic.State
{
    public interface IAgentState
    {
        void hitted(AgentV2 aAgent);
        void heal(AgentV2 aAgent);
        void search(AgentV2 agentV2);
        void fight(AgentV2 agentV2);
    }
}