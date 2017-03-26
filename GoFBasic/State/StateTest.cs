using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoFBasic.State
{
    [TestClass]
    public class StateTest
    {
        private const int MAX_HP = 100;

        [TestMethod]
        public void test_default_state_when_game_start()
        {
            AgentV2 agent = new AgentV2();
            Assert.IsNotNull(agent.getState());
            IAgentState health = new Health();
            Assert.AreEqual(health.GetType(), agent.getState().GetType(), "Test default state is Health");
            Assert.AreEqual(MAX_HP, agent.getHP(), "Test default HP is MAX_HP");
        }
    }
}
