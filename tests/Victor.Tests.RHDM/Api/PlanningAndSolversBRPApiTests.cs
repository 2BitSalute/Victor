/* 
 * KIE Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Victor.CUI.RHDM.KIE.Client;
using Victor.CUI.RHDM.KIE.Api;
using Victor.CUI.RHDM.KIE.Model;

namespace Victor.Tests.RHDM
{
    /// <summary>
    ///  Class for testing PlanningAndSolversBRPApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlanningAndSolversBRPApiTests
    {
        private PlanningAndSolversBRPApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlanningAndSolversBRPApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlanningAndSolversBRPApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PlanningAndSolversBRPApi
            //Assert.IsInstanceOfType(typeof(PlanningAndSolversBRPApi), instance, "instance is a PlanningAndSolversBRPApi");
        }

        
        /// <summary>
        /// Test AddProblemFactChanges
        /// </summary>
        [Test]
        public void AddProblemFactChangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //string body = null;
            //instance.AddProblemFactChanges(containerId, solverId, body);
            
        }
        
        /// <summary>
        /// Test CreateSolver
        /// </summary>
        [Test]
        public void CreateSolverTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //string body = null;
            //var response = instance.CreateSolver(containerId, solverId, body);
            //Assert.IsInstanceOf<SolverInstance> (response, "response is SolverInstance");
        }
        
        /// <summary>
        /// Test DisposeSolver
        /// </summary>
        [Test]
        public void DisposeSolverTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //instance.DisposeSolver(containerId, solverId);
            
        }
        
        /// <summary>
        /// Test GetSolver
        /// </summary>
        [Test]
        public void GetSolverTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //var response = instance.GetSolver(containerId, solverId);
            //Assert.IsInstanceOf<SolverInstance> (response, "response is SolverInstance");
        }
        
        /// <summary>
        /// Test GetSolverWithBestSolution
        /// </summary>
        [Test]
        public void GetSolverWithBestSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //var response = instance.GetSolverWithBestSolution(containerId, solverId);
            //Assert.IsInstanceOf<SolverInstance> (response, "response is SolverInstance");
        }
        
        /// <summary>
        /// Test GetSolvers
        /// </summary>
        [Test]
        public void GetSolversTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //var response = instance.GetSolvers(containerId);
            //Assert.IsInstanceOf<Solvers> (response, "response is Solvers");
        }
        
        /// <summary>
        /// Test IsEveryProblemFactChangeProcessed
        /// </summary>
        [Test]
        public void IsEveryProblemFactChangeProcessedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //var response = instance.IsEveryProblemFactChangeProcessed(containerId, solverId);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test SolvePlanningProblem
        /// </summary>
        [Test]
        public void SolvePlanningProblemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //string body = null;
            //instance.SolvePlanningProblem(containerId, solverId, body);
            
        }
        
        /// <summary>
        /// Test TerminateSolverEarly
        /// </summary>
        [Test]
        public void TerminateSolverEarlyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string solverId = null;
            //instance.TerminateSolverEarly(containerId, solverId);
            
        }
        
    }

}
