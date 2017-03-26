using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoFBasic.State
{
    [TestClass]
    public class StateTest
    {
        private const int MAX_HP = 100;

        AgentV2 agent = new AgentV2();
        IAgentState health = new Health();
        IAgentState injured = new Injured();


        [TestMethod]
        public void test_default_state_when_game_start()
        {
            
            Assert.IsNotNull(agent.getState());
            
            Assert.AreEqual(health.GetType(), agent.getState().GetType(), "Test default state is Health");
            Assert.AreEqual(MAX_HP, agent.getHP(), "Test default HP is MAX_HP");
        }

        [TestMethod]
        public void test_Health_state_heal_is_Health_state()
        {
            agent.heal(80);
            Assert.AreEqual(health.GetType(), agent.getState().GetType());
            Assert.AreEqual(MAX_HP, agent.getHP(), "Test heal(Health -> Health)");

        }

        [TestMethod]
        public void test_Health_and_Injured_change_State()
        {
            agent.hitted(30);
            Assert.AreEqual(health.GetType(), agent.getState().GetType());
            agent.hitted(1);
            Assert.AreEqual(injured.GetType(), agent.getState().GetType());
            agent.heal(80);
            Assert.AreEqual(health.GetType(), agent.getState().GetType());
            Assert.AreEqual(MAX_HP, agent.getHP(), "Test heal(Injured -> Health)");
        }
    }
}
