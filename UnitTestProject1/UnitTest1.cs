using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TextInputTest()
        {
            TextInput input = new TextInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            input.Add(' ');

            Assert.AreEqual(input.GetValue(), "1a0 ");
        }

        [TestMethod]
        public void NumInputTest()
        {
            NumericInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            input.Add(' ');

            Assert.AreEqual(input.GetValue(), "10");
        }

        [TestMethod]
        public void TextNumInputTest()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            input.Add(' ');

            Assert.AreEqual(input.GetValue(), "10");
        }
    }
}
