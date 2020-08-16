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
                ColumnNum = "A"
            };
            Assert.AreEqual(node.ColumnNum, "A");
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
                ColumnNum = "A",
            };
            Assert.AreEqual(node.ToString(), "FieldName=FieldName, LabelName=LabelName, ColumnNum=A");
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("FieldName", "LabelName", "", false)]
        [DataRow("FieldName", "LabelName", "", false)]
        [DataRow("", "LabelName", "A", false)]
        [DataRow("FieldName", "", "A", false)]
        [DataRow("", "", "A", false)]
        [DataRow("FieldName", "LabelName", "AA", true)]
        public void TestCheck(String s1, String s2, String s3, Boolean b1)
        {
            ExcelNode node = new ExcelNode
            {
                FieldName = s1,
                LabelName = s2,
                ColumnNum = s3
            };
            Assert.AreEqual(node.Check(), b1);
        }
    }
}
