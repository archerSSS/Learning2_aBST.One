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
            abst.AddKey(30);
            int index = abst.AddKey(31);

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
            Assert.AreEqual(30, abst.Tree[30]);
            Assert.AreEqual(-1, index);
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
            aBST abst = GetTree_1();
            Assert.AreEqual(13, abst.Tree[10]);
            Assert.AreEqual(null, abst.Tree[8]);
        }

        [TestMethod]
        public void TestAdd_3()
        {
            aBST abst = new aBST(2);
            Assert.AreEqual(0, abst.AddKey(16));
            Assert.AreEqual(2, abst.AddKey(74));
            Assert.AreEqual(1, abst.AddKey(-329));
            Assert.AreEqual(-1, abst.AddKey(-339));
        }

        [TestMethod]
        public void TestAdd_4()
        {
            aBST abst = new aBST(0);
            Assert.AreEqual(-1, abst.AddKey(16));
            Assert.AreEqual(-1, abst.AddKey(74));
            Assert.AreEqual(-1, abst.AddKey(-329));
            Assert.AreEqual(-1, abst.AddKey(-339));

            aBST abst2 = new aBST(1);

            Assert.AreEqual(0, abst2.AddKey(16));
            Assert.AreEqual(-1, abst2.AddKey(11));
        }

        [TestMethod]
        public void TestAdd_5()
        {
            aBST abst = new aBST(10);
            Assert.AreEqual(1023, abst.Tree.Length);
        }


        [TestMethod]
        public void TestFind_1()
        {
            aBST abst = GetTree_1();

            Assert.AreEqual(10, abst.FindKeyIndex(13));
        }

        [TestMethod]
        public void TestFind_2()
        {
            aBST abst = GetTree_1();

            Assert.AreEqual(0, abst.FindKeyIndex(16));
            Assert.AreEqual(1, abst.FindKeyIndex(8));
            Assert.AreEqual(2, abst.FindKeyIndex(24));
            Assert.AreEqual(3, abst.FindKeyIndex(4));
            Assert.AreEqual(4, abst.FindKeyIndex(12));
            Assert.AreEqual(5, abst.FindKeyIndex(22));
            Assert.AreEqual(6, abst.FindKeyIndex(28));
            Assert.AreEqual(7, abst.FindKeyIndex(-1));
            Assert.AreEqual(9, abst.FindKeyIndex(11));
            Assert.AreEqual(10, abst.FindKeyIndex(13));
            Assert.AreEqual(12, abst.FindKeyIndex(23));

            Assert.AreEqual(4, abst.FindKeyIndex(12));

            Assert.AreEqual(0, abst.FindKeyIndex(16));
            Assert.AreEqual(1, abst.FindKeyIndex(8));
            Assert.AreEqual(2, abst.FindKeyIndex(24));
            Assert.AreEqual(3, abst.FindKeyIndex(4));
            Assert.AreEqual(4, abst.FindKeyIndex(12));
            Assert.AreEqual(5, abst.FindKeyIndex(22));
            Assert.AreEqual(6, abst.FindKeyIndex(28));
            Assert.AreEqual(7, abst.FindKeyIndex(-1));
            Assert.AreEqual(9, abst.FindKeyIndex(11));
            Assert.AreEqual(10, abst.FindKeyIndex(13));
            Assert.AreEqual(12, abst.FindKeyIndex(23));
        }

        [TestMethod]
        public void TestFind_3()
        {
            aBST abst = GetTree_1();
            int b1 = abst.AddKey(19);
            int b2 = abst.AddKey(18);
            int b3 = abst.AddKey(17);

            Assert.AreEqual(11, b1);
            Assert.AreEqual(23, b2);
            Assert.AreEqual(-1, b3);

            Assert.AreEqual(null, abst.FindKeyIndex(20));
            Assert.AreEqual(0, abst.FindKeyIndex(16));
            Assert.AreEqual(5, abst.FindKeyIndex(22));
            Assert.AreEqual(11, abst.FindKeyIndex(19));
            Assert.AreEqual(23, abst.FindKeyIndex(18));
            Assert.AreEqual(null, abst.FindKeyIndex(17));
        }

        [TestMethod]
        public void TestFind_4()
        {
            aBST abst = new aBST(3);
            abst.AddKey(16);
            
            Assert.AreEqual(-1, abst.FindKeyIndex(10));
            Assert.AreEqual(-2, abst.FindKeyIndex(18));

            abst.AddKey(18);

            Assert.AreEqual(2, abst.FindKeyIndex(18));
            Assert.AreEqual(-6, abst.FindKeyIndex(20));
        }

        [TestMethod]
        public void TestOverAll_1()
        {
            aBST abst = new aBST(4);

            Assert.AreEqual(0, abst.AddKey(16));

            Assert.AreEqual(1, abst.AddKey(4));
            Assert.AreEqual(2, abst.AddKey(24));

            Assert.AreEqual(3, abst.AddKey(-2));
            Assert.AreEqual(4, abst.AddKey(12));
            Assert.AreEqual(5, abst.AddKey(20));
            Assert.AreEqual(6, abst.AddKey(28));

            Assert.AreEqual(7, abst.AddKey(-3));
            Assert.AreEqual(8, abst.AddKey(-1));
            Assert.AreEqual(9, abst.AddKey(8));
            Assert.AreEqual(10, abst.AddKey(14));
            Assert.AreEqual(11, abst.AddKey(18));
            Assert.AreEqual(12, abst.AddKey(22));
            Assert.AreEqual(13, abst.AddKey(26));
            Assert.AreEqual(14, abst.AddKey(30));

            Assert.AreEqual(14, abst.AddKey(30));
            Assert.AreEqual(-1, abst.AddKey(32));

            Assert.AreEqual(0, abst.FindKeyIndex(16));

            Assert.AreEqual(1, abst.FindKeyIndex(4));
            Assert.AreEqual(2, abst.FindKeyIndex(24));

            Assert.AreEqual(3, abst.FindKeyIndex(-2));
            Assert.AreEqual(4, abst.FindKeyIndex(12));
            Assert.AreEqual(5, abst.FindKeyIndex(20));
            Assert.AreEqual(6, abst.FindKeyIndex(28));

            Assert.AreEqual(7, abst.FindKeyIndex(-3));
            Assert.AreEqual(8, abst.FindKeyIndex(-1));
            Assert.AreEqual(9, abst.FindKeyIndex(8));
            Assert.AreEqual(10, abst.FindKeyIndex(14));
            Assert.AreEqual(11, abst.FindKeyIndex(18));
            Assert.AreEqual(12, abst.FindKeyIndex(22));
            Assert.AreEqual(13, abst.FindKeyIndex(26));
            Assert.AreEqual(14, abst.FindKeyIndex(30));

            abst.Tree[14] = null;

            Assert.AreEqual(-14, abst.FindKeyIndex(30));
            Assert.AreEqual(14, abst.AddKey(30));
            Assert.AreEqual(14, abst.FindKeyIndex(30));
        }



        /*
             *               16
             *           8       24       
             *        4   12   22   28
             *      -1  11 13   23 
             * 
             */
        private aBST GetTree_1()
        {
            aBST abst = new aBST(5);
            abst.AddKey(16);
            abst.AddKey(8);
            abst.AddKey(4);
            abst.AddKey(-1);
            abst.AddKey(12);
            abst.AddKey(13);
            abst.AddKey(11);
            abst.AddKey(24);
            abst.AddKey(22);
            abst.AddKey(23);
            abst.AddKey(28);
            return abst;
        }
    }
}
