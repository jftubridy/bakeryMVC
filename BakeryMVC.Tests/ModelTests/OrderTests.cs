// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using BakeryMVC.Models;
// using System.Collections.Generic;
// using System;

// namespace BakeryMVC.TestTools
// {
//     [TestClass]
//     public class OrderControllerTest
//     {

//         [TestMethod]
//         public void Find_ReturnsCorrectOrder_Order()
//         {
//             //Arrange
//             string description01 = "Walk the dog";
//             string description02 = "Wash the dishes";
//             Order newOrder1 = new Order(description01);
//             Order newOrder2 = new Order(description02);

//             //Act
//             Order result = Order.Find(2);

//             //Assert
//             Assert.AreEqual(newOrder2, result);
//         }
//     }
// }