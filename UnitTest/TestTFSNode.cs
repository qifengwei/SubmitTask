using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubmitTask;
using SubmitTask.Saved;

namespace UnitTest
{
    [TestClass]
    public class TestTFSNode
    {
        [TestMethod]
        public void GetFieldName()
        {
            TFSNode node = new TFSNode
            {
                FieldName = "FieldName",
                LabelName = "LabelName",
                DefaultText = "DefaultText",
                DefaultOption = new List<String> { "Option1", "Option2", "Option3" }
            };
            Assert.AreEqual(node.FieldName, "FieldName");
            Assert.AreEqual(node.LabelName, "LabelName");
            Assert.AreEqual(node.DefaultText, "DefaultText");
            for (int i = 0; i < node.DefaultOption.Count; i++)
            {
                Assert.AreEqual(node.DefaultOption[i], $"Option{i + 1}");
            }
        }

        [TestMethod]
        public void TestToString()
        {
            TFSNode node = new TFSNode
            {
                FieldName = "FieldName",
                LabelName = "LabelName",
                DefaultText = "DefaultText",
                DefaultOption = new List<String> { "Option1", "Option2", "Option3" }
            };
            String list = "";
            foreach (var s in node.DefaultOption) list += $"{s}, ";
            Assert.AreEqual(node.ToString(), $"Field=FieldName, LabelName=LabelName, " +
                $"DefaultText=DefaultText, DefaultOption=Option1, Option2, Option3, ");
        }
        [TestMethod]
        public void TestToString3Param()
        {
            TFSNode node = new TFSNode
            {
                FieldName = "FieldName",
                LabelName = "LabelName",
                DefaultText = "DefaultText",
            };
            String list = "";
            foreach (var s in node.DefaultOption) list += $"{s}, ";
            Assert.AreEqual(node.ToString(), $"Field=FieldName, LabelName=LabelName, " +
                $"DefaultText=DefaultText, DefaultOption=");
        }
        [TestMethod]
        public void TestToString1Param()
        {
            TFSNode node = new TFSNode
            {
                FieldName = "FieldName",
            };
            String list = "";
            foreach (var s in node.DefaultOption) list += $"{s}, ";
            Assert.AreEqual(node.ToString(), $"Field=FieldName, LabelName=, " +
                $"DefaultText=, DefaultOption=");
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("FieldName", "LabelName", "DefaultText", true)]
        [DataRow("FieldName", "LabelName", "", true)]
        [DataRow("FieldName", "", "DefaultText", false)]
        [DataRow("", "LabelName", "DefaultText", false)]
        public void TestCheck(String s1, String s2, String s3, Boolean b4)
        {
            List<String> defaultOption3 = new List<string> { "Op1", "Op2", "Op3" };
            List<String> defaultOption0 = new List<string> { };
            TFSNode node = new TFSNode
            {
                FieldName = s1,
                LabelName = s2,
                DefaultText = s3,
                DefaultOption = defaultOption3
            };
            Assert.AreEqual(b4, node.Check());
        }
    }
}
