using System;

namespace GoFBasic.State
{
    public class AgentV2
    {
        private const int MAX_HP = 100;

        private IAgentState _currentState = null;

        private int _HP = 0;


        public AgentV2()
        {
            _currentState = new Health();
            _HP = MAX_HP;
        }

        public IAgentState getState()
        {
            return _currentState;
        }

        public int getHP()
        {
            return _HP;
        }
    }
}