using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
    [TestClass]
    public class ScrabbleScoreTests : IDisposable
    {

        public void Dispose()
        {
            // Item.ClearAll();
        }

        // [TestMethod]
        // public void GetScore_ConvertUserWordToArray_Array()
        // {
            
        //     Assert.AreEqual(typeof(PrimeNum), newItem.GetType());
        // }

        // [TestMethod]
        // public void GetScore_AddsValuesForEachLetter_Int()
        // {
            
        //     Assert.AreEqual(typeof(PrimeNum), newItem.GetType());
        // }

        // // [TestMethod]
        // // public void GenNumerals_GeneratedADictionaryWithKVPair_Dictionary()
        // // {
        // //     //Arrange
        // //     // GenNumber(userenterednumber)
        // //     int userEnteredNum = 100;
        // //     PrimeNum primeObject = new PrimeNum();

        // //     //Act
        // //     Dictionary<int, string> allNumbers = new Dictionary<int, string>() { };
        // //     for (int i = 2; i <= userEnteredNum; i++)
        // //     {
        // //         allNumbers[i] = "unProcessed";
        // //     }
        // //     Dictionary<int, string> result = primeObject.GenNumber(userEnteredNum);

        // //     //Assert
        // //     CollectionAssert.AreEqual(allNumbers, result);
        // // }

        // // [TestMethod]
        // // public void SetDescription_SetDescription_String()
        // // {
        // //     //Arrange
        // //     string description = "Walk the dog2.";
        // //     Item newItem = new Item(description);

        // //     //Act
        // //     string updatedDescription = "Do the dishes";
        // //     newItem.Description = updatedDescription;
        // //     string result = newItem.Description;

        // //     //Assert
        // //     Assert.AreEqual(updatedDescription, result);
        // // }

        // // [TestMethod]
        // // public void GetAll_ReturnsEmptyList_ItemList()
        // // {
        // //     // Arrange
        // //     List<Item> newList = new List<Item> { };

        // //     // Act
        // //     List<Item> result = Item.GetAll();

        // //     foreach (Item thisItem in result)
        // //     {
        // //         Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
        // //     }
        // //     // Assert
        // //     CollectionAssert.AreEqual(newList, result);
        // // }

        // // [TestMethod]
        // // public void GetAll_ReturnsItems_ItemList()
        // // {
        // //     //Arrange
        // //     string description01 = "Walk the dog3";
        // //     string description02 = "Wash the dishes";
        // //     Item newItem1 = new Item(description01);
        // //     Item newItem2 = new Item(description02);
        // //     List<Item> newList = new List<Item> { newItem1, newItem2 };

        // //     //Act
        // //     List<Item> result = Item.GetAll();

        // //     foreach (Item thisItem in result)
        // //     {
        // //         Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
        // //     }

        // //     //Assert
        // //     CollectionAssert.AreEqual(newList, result);
        // // }
    }
}