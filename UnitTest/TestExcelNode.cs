using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubmitTask.Saved;

namespace UnitTest
{
    [TestClass]
    public class TestExcelNode
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExcelNode node = new ExcelNode
            {
                FieldName = "FieldName",
                LabelName = "LabelName",
                ColumnNum = 5
            };
            Assert.AreEqual(node.ColumnNum, 5);
            Assert.AreEqual(node.FieldName, "FieldName");
            Assert.AreEqual(node.LabelName, "LabelName");
        }

        [TestMethod]
        public void TestToString()
        {
            ExcelNode node = new ExcelNode
            {
                FieldName = "FieldName",
                LabelName = "LabelName",
                ColumnNum = 5
            };
            Assert.AreEqual(node.ToString(), "FieldName=FieldName, LabelName=LabelName, ColumnNum=5");
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("FieldName", "LabelName", 0, false)]
        [DataRow("FieldName", "LabelName", -5, false)]
        [DataRow("", "LabelName", 5, false)]
        [DataRow("FieldName", "", 5, false)]
        [DataRow("", "", 5, false)]
        [DataRow("FieldName", "LabelName", 1, true)]
        public void TestCheck(String s1, String s2, Int32 i1, Boolean b1)
        {
            ExcelNode node = new ExcelNode
            {
                FieldName = s1,
                LabelName = s2,
                ColumnNum = i1
            };
            Assert.AreEqual(node.Check(), b1);
        }
    }
}
