using System;

namespace GoFBasic.State
{
    public class AgentV2
    {
        private const int MAX_HP = 100;
        internal const int HEALTH_LOW_LIMIT = 70;
        internal const int INJURED_LOW_LIMIT = 1;
        internal const int DEAD_LOW_LIMIT = 0;
        internal IAgentState _currentState = null;

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

        public void heal(int aValue)
        {
            if (_HP + aValue <= MAX_HP)
            {
                _HP = _HP + aValue;
            }
            else
            {
                _HP = MAX_HP;
            }
            _currentState.heal(this);
        }

        public void hitted(int aValue)
        {
            if (_HP - aValue >= DEAD_LOW_LIMIT)
            {
                _HP = _HP - aValue;
            }
            else
            {
                _HP = DEAD_LOW_LIMIT;
            }
            _currentState.hitted(this);
        }

        public void changeState(IAgentState aState)
        {
            _currentState = aState;
        }
    }
}