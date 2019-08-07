using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd_1()
        {
            aBST abst = new aBST(5); 
            abst.AddKey(16);    

            abst.AddKey(8);     
            abst.AddKey(3);     
            abst.AddKey(10);    
            abst.AddKey(12);    
            abst.AddKey(9);     

            abst.AddKey(24);    
            abst.AddKey(19);    
            abst.AddKey(17);    
            abst.AddKey(28);    
            abst.AddKey(26);    
            abst.AddKey(29);    

            Assert.AreEqual(31, abst.Tree.Length);

            Assert.AreEqual(16, abst.Tree[0]);
            Assert.AreEqual(8, abst.Tree[1]);
            Assert.AreEqual(24, abst.Tree[2]);
            Assert.AreEqual(3, abst.Tree[3]);
            Assert.AreEqual(10, abst.Tree[4]);
            Assert.AreEqual(19, abst.Tree[5]);
            Assert.AreEqual(28, abst.Tree[6]);
            Assert.AreEqual(null, abst.Tree[7]);
            Assert.AreEqual(null, abst.Tree[8]);
            Assert.AreEqual(9, abst.Tree[9]);
            Assert.AreEqual(12, abst.Tree[10]);
            Assert.AreEqual(17, abst.Tree[11]);
            Assert.AreEqual(null, abst.Tree[12]);
            Assert.AreEqual(26, abst.Tree[13]);
            Assert.AreEqual(29, abst.Tree[14]);
            /*
             *               16
             *           8       24       
             *        3   10   19   28
             *           9 12 17   26 29
             * 
             */
        }

        [TestMethod]
        public void TestAdd_2()
        {

        }

        private aBST GetTree_1()
        {
            aBST abst = new aBST(5);
            abst.AddKey(2);
            return abst;
        }
    }
}
