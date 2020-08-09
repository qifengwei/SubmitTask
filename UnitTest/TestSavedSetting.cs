using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubmitTask.Saved;

namespace UnitTest
{
    [TestClass]
    public class TestSavedSetting
    {
        [TestMethod]
        public void TestClear()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            ExcelNode enode = new ExcelNode();
            setting.AddExcelNode(enode);
            TFSNode tnode = new TFSNode();
            setting.AddTFSNode(tnode);
            setting.Clear();
            Assert.AreEqual(0, setting.ExcelSize);
            Assert.AreEqual(0, setting.Size);
            Assert.AreEqual(0, setting.TFSSize);
        }

        [TestMethod]
        public void TestClearExcelNodesList()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            setting.Clear();
            ExcelNode enode = new ExcelNode() { LabelName = "1", FieldName = "2", ColumnNum = 3 };
            setting.AddExcelNode(enode);
            TFSNode tnode = new TFSNode() { LabelName = "1", FieldName = "2" };
            setting.AddTFSNode(tnode);
            setting.ClearExcelNodesList();
            Assert.AreEqual(0, setting.ExcelSize);
            Assert.AreEqual(1, setting.Size);
            Assert.AreEqual(1, setting.TFSSize);
        }

        [TestMethod]
        public void TestClearTFSNodesList()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            setting.Clear();
            ExcelNode enode = new ExcelNode() { LabelName = "1", FieldName = "2", ColumnNum = 3 };
            setting.AddExcelNode(enode);
            TFSNode tnode = new TFSNode() { LabelName = "1", FieldName = "2" };
            setting.AddTFSNode(tnode);
            setting.ClearTFSNodesList();
            Assert.AreEqual(1, setting.ExcelSize);
            Assert.AreEqual(1, setting.Size);
            Assert.AreEqual(0, setting.TFSSize);
        }

        [TestMethod]
        public void TestAddExcelNode()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            ExcelNode node = new ExcelNode() { LabelName="1", FieldName="2", ColumnNum = 3};
            setting.Clear();
            Assert.IsTrue(setting.AddExcelNode(node));
            Assert.AreEqual(1, setting.ExcelSize);
            Assert.AreEqual(1, setting.Size);
            Assert.AreEqual(0, setting.TFSSize);
        }

        [TestMethod]
        public void TestAddTFSNode()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            TFSNode node = new TFSNode() { LabelName = "1", FieldName = "2"};
            setting.Clear();
            Assert.IsTrue(setting.AddTFSNode(node));
            Assert.AreEqual(1, setting.TFSSize);
            Assert.AreEqual(1, setting.Size);
            Assert.AreEqual(0, setting.ExcelSize);
        }

        [TestMethod]
        public void TestAddTFSNodeF()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            TFSNode node = new TFSNode() { LabelName = "1", FieldName = "2" };
            TFSNode node2 = new TFSNode() { LabelName = "1", FieldName = "2" };
            setting.Clear();
            Assert.IsTrue(setting.AddTFSNode(node));
            Assert.IsFalse(setting.AddTFSNode(node));
            Assert.IsFalse(setting.AddTFSNode(node2));
            Assert.AreEqual(1, setting.TFSSize);
            Assert.AreEqual(1, setting.Size);
            Assert.AreEqual(0, setting.ExcelSize);
        }

        [TestMethod]
        public void TestAddTFSNodes()
        {
            SavedSetting setting = SavedSetting.GetInstance();
            List<TFSNode> nodes = new List<TFSNode> {
                new TFSNode(){ LabelName = "1", FieldName = "2"},
                new TFSNode(){ LabelName = "1", FieldName = "2"} };
            setting.Clear();
            setting.AddTFSNodes(nodes);
            Assert.AreEqual(2, setting.TFSSize);
            Assert.AreEqual(2, setting.Size);
            Assert.AreEqual(0, setting.ExcelSize);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("1","2",3,"1","2",3,1)]
        [DataRow("1", "2", 3, "2", "2", 3, 1)]
        [DataRow("1", "2", 1, "1", "2", 3, 1)]
        [DataRow("1", "3", 3, "1", "2", 3, 2)]
        public void TestAddExcelNodes(string s1, string s2, int i3, string s4, string s5, int i6, int i7)
        {
            SavedSetting setting = SavedSetting.GetInstance();
            List<ExcelNode> nodes =
                new List<ExcelNode> { 
                    new ExcelNode() { LabelName = s1, FieldName = s2, ColumnNum = i3 },
                    new ExcelNode() { LabelName = s4, FieldName = s5, ColumnNum = i6} 
                };
            setting.Clear();
            setting.AddExcelNodes(nodes);
            Assert.AreEqual(i7, setting.ExcelSize);
            Assert.AreEqual(i7, setting.Size);
            Assert.AreEqual(0, setting.TFSSize);
        }
    }
}
