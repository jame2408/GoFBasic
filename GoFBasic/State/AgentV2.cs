using System;

namespace GoFBasic.State
{
    public class AgentV2
    {
        internal static IAgentState Health_STATE = new Health();
        internal static IAgentState Injured_STATE = new Injured();
        internal static IAgentState Dying_STATE = new Dying();
        internal static IAgentState Dead_STATE = new Dead();

        internal const int HEALTH_LOW_LIMIT = 70;
        internal const int INJURED_LOW_LIMIT = 30;
        internal const int DYING_LOW_LIMIT = 1;
        internal const int DEAD_LOW_LIMIT = 0;

        private const int MAX_HP = 100;
        private IAgentState _currentState = null;
        private int _HP = 0;


        public AgentV2(IAgentState currentState)
        {
            _currentState = currentState;
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

        public void search()
        {
            _currentState.search(this);
        }

        public void fight()
        {
            _currentState.fight(this);
        }
    }
}