using System;
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
    }
}
