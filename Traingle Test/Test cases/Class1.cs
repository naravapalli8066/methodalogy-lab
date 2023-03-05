using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traingle_Test;


namespace Testclass
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 60;
                int second_angle = 60;
                int third_angle = 60;
                string expected = "the traingle is valid";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);


