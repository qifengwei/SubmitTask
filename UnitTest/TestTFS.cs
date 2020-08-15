using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubmitTask.TFS;

namespace UnitTest
{
    [TestClass]
    public class TestTFS
    {
        [TestMethod]
        public void TestConnectTFS()
        {
            TFS tfs = new TFS();
            Assert.IsTrue(tfs.ConnectTFS());
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("someone", "password", false)]
        [DataRow("fengwei.qi@united-imaging.com", "8x81v1yN", true)]
        public void TestConnectTFSWithName2(string name, string password, Boolean ok)
        {
            TFS tfs = new TFS();
            Assert.AreEqual(ok, tfs.ConnectTFS(name, password));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("someone", "password", "domain", false)]
        [DataRow("fengwei.qi", "8x81v1yN", "united-imaging.com", true)]
        public void TestConnectTFSWithName3(string name, string password, string domain, Boolean ok)
        {
            TFS tfs = new TFS();
            Assert.AreEqual(ok, tfs.ConnectTFS(name, password, domain));
        }
        
        [TestMethod]
        [DataTestMethod]
        [DataRow("DIM", true)]
        [DataRow("123", false)]
        [DataRow("XR_LouTang", true)]
        public void TestChangeWorkItemStore(string name, Boolean ok)
        {
            TFS tfs = new TFS();
            Assert.AreEqual(ok, tfs.ChangeWorkItemStore(name));
            _ = tfs;
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("TASK", true)]
        [DataRow("123", false)]
        [DataRow("SFS", false)]
        public void TestChangeWorkItemType(string name, Boolean ok)
        {
            TFS tfs = new TFS();
            Assert.AreEqual(ok, tfs.ChangeWorkItemType(name));
        }

        [TestMethod]
        public void TestGetWorkItemType()
        {
            TFS tfs = new TFS();
            Assert.AreEqual(tfs.ItemType.Name, tfs.GetWorkItemType("TASK").Name);
        }

        [TestMethod]
        public void TestGetIterationRootNodes()
        {
            TFS tfs = new TFS();
            Assert.IsTrue(tfs.GetIterationRootNodes() is NodeCollection);
        }

        [TestMethod]
        public void TestGetTopNode()
        {
            TFS tfs = new TFS();
            Assert.AreEqual(tfs.GetTopIterationNode("XR").Id, 23793);
            Assert.AreEqual(tfs.GetTopIterationNode(7).Name, "XR");
        }

        [TestMethod]
        public void TestFindIterationNode()
        {
            TFS tfs = new TFS();
            Assert.AreEqual(tfs.FindIterationNode("XR").Name, "XR");
            Assert.AreEqual(tfs.FindIterationNode("15-LouTang").Name, "15-LouTang");
            Assert.AreEqual(tfs.FindIterationNode("123"), null);
        }

        [TestMethod]
        public void TestGetAreaRootNodes()
        {
            TFS tfs = new TFS();
            Assert.IsTrue(tfs.GetAreaRootNodes() is NodeCollection);
        }

        [TestMethod]
        public void TestGetTopAreaNode()
        {
            TFS tfs = new TFS();
            Assert.AreEqual(tfs.GetTopAreaNode("XR").Id, 23792);
            Assert.AreEqual(tfs.GetTopAreaNode(11).Name, "XR");
        }

        [TestMethod]
        public void TestFindAreaNode()
        {
            TFS tfs = new TFS();
            Assert.AreEqual(tfs.FindAreaNode("XR").Name, "XR");
            Assert.AreEqual(tfs.FindAreaNode("08_Loutang").Name, "08_Loutang");
            Assert.AreEqual(tfs.FindAreaNode("123"), null);
        }

        [TestMethod]
        public void TestGetAllChildNodesName()
        {
            TFS tfs = new TFS();
            Assert.IsTrue(tfs.GetAllChildNodesName(tfs.GetAreaRootNodes()) is List<String>);
            Assert.IsTrue(tfs.GetAllChildNodesName(tfs.FindAreaNode("XR")) is List<String>);
            var s = tfs.GetAllChildNodesName(tfs.FindAreaNode("XR"));
            Assert.IsTrue(tfs.GetAllChildNodesName(tfs.FindAreaNode(23792)).Contains("08_Loutang"));
            Assert.IsTrue(tfs.GetAllChildNodesName(tfs.GetAreaRootNodes()).Contains("08_Loutang"));
            Assert.IsTrue(!tfs.GetAllChildNodesName(tfs.GetAreaRootNodes()).Contains("123"));
        }
    }
}
