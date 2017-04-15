using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace GoFBasic.State
{
    [TestClass]
    public class StateTest
    {
        private const int MAX_HP = 100;
        private const int MIN_HP = 0;

        AgentV2 agent = new AgentV2(new Health());
        IAgentState health = new Health();
        IAgentState injured = new Injured();
        IAgentState dead = new Dead();

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

        [TestMethod]
        public void test_Health_and_Dead_change_State()
        {
            agent.hitted(101);
            Assert.AreEqual(dead.GetType(), agent.getState().GetType());
            Assert.AreEqual(MIN_HP, agent.getHP(), "Test heal(Health -> Dead)");
            agent.heal(80);
            Assert.AreEqual(health.GetType(), agent.getState().GetType());

        }

        [TestMethod]
        public void test_Injured_and_Dead_change_State()
        {
            agent.hitted(31);
            Assert.AreEqual(injured.GetType(), agent.getState().GetType());
            agent.hitted(70);
            Assert.AreEqual(dead.GetType(), agent.getState().GetType());
            Assert.AreEqual(MIN_HP, agent.getHP(), "Test heal(Injured -> Dead)");
            agent.heal(1);
            Assert.AreEqual(injured.GetType(), agent.getState().GetType());
        }

        [TestMethod]
        public void test_received_search_once()
        {
            var nsub = Substitute.For<IAgentState>();
            var agentV2 = new AgentV2(nsub);
            agentV2.search();
            nsub.Received(1).search(agentV2);
        }

        [TestMethod]
        public void test_received_fight_once()
        {
            var nsub = Substitute.For<IAgentState>();
            var agentV2 = new AgentV2(nsub);
            agentV2.fight();
            nsub.Received(1).fight(agentV2);
        }
    }
}
