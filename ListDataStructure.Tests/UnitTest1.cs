using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListsDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDataStructure.Tests
{
    [TestClass()]
    public class MyArrayListTests
    {
        [TestMethod()]
        public void Append_SingleElement_ShouldAddToEnd()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Append_MultipleElements_ShouldAddToEnd()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            list.Append(1);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[1], 1);
        }

        [TestMethod()]
        public void Append_AddMoreElementsThanSizeAllows_ShouldAddToEnd()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            list.Append(1);
            list.Append(7);
            list.Append(1);
            list.Append(8);
            list.Append(0);
            list.Append(9);
            list.Append(41);
            list.Append(70);
            list.Append(91);
            list.Append(32);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[list.Size - 1], 32);
        }

        [TestMethod()]
        public void AddStart_ListIsEmpty_ShouldAddToStart()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void AddStart_ListHasValues_ShouldAddToStart()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            list.Append(10);
            list.Append(5);
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }
    }
}