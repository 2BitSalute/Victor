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
    ///  Class for testing KIEServerAndKIEContainersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KIEServerAndKIEContainersApiTests
    {
        private KIEServerAndKIEContainersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            var config = new Configuration();
            config.BasePath = "https://victor-kieserver-evals25-shared-7daa.apps.hackathon.rhmi.io/";
            config.Username = "allisterb2";
            config.Password = "allisterb2";
            instance = new KIEServerAndKIEContainersApi(config);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KIEServerAndKIEContainersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KIEServerAndKIEContainersApi
            //Assert.IsInstanceOfType(typeof(KIEServerAndKIEContainersApi), instance, "instance is a KIEServerAndKIEContainersApi");
        }

        
        /// <summary>
        /// Test ActivateContainer
        /// </summary>
        [Test]
        public void ActivateContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.ActivateContainer(containerId);
            
        }
        
        /// <summary>
        /// Test CreateContainer
        /// </summary>
        [Test]
        public void CreateContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string body = null;
            //instance.CreateContainer(containerId, body);
            
        }
        
        /// <summary>
        /// Test DeactivateContainer
        /// </summary>
        [Test]
        public void DeactivateContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.DeactivateContainer(containerId);
            
        }
        
        /// <summary>
        /// Test DisposeContainer
        /// </summary>
        [Test]
        public void DisposeContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.DisposeContainer(containerId);
            
        }
        
        /// <summary>
        /// Test ExecuteCommands
        /// </summary>
        [Test]
        public void ExecuteCommandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //instance.ExecuteCommands(body);
            
        }
        
        /// <summary>
        /// Test GetContainerInfo
        /// </summary>
        [Test]
        public void GetContainerInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.GetContainerInfo(containerId);
            
        }
        
        /// <summary>
        /// Test GetInfo
        /// </summary>
        [Test]
        public void GetInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            instance.GetInfo();
            
        }
        
        /// <summary>
        /// Test GetReleaseId
        /// </summary>
        [Test]
        public void GetReleaseIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.GetReleaseId(containerId);
            
        }
        
        /// <summary>
        /// Test GetScannerInfo
        /// </summary>
        [Test]
        public void GetScannerInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //instance.GetScannerInfo(containerId);
            
        }
        
        /// <summary>
        /// Test GetServerState
        /// </summary>
        [Test]
        public void GetServerStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetServerState();
            
        }
        
        /// <summary>
        /// Test Healthcheck
        /// </summary>
        [Test]
        public void HealthcheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? report = null;
            //var response = instance.Healthcheck(report);
            //Assert.IsInstanceOf<List<KieMessage>> (response, "response is List<KieMessage>");
        }
        
        /// <summary>
        /// Test ListContainers
        /// </summary>
        [Test]
        public void ListContainersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //string artifactId = null;
            //string version = null;
            //string status = null;
            //instance.ListContainers(groupId, artifactId, version, status);
            
        }
        
        /// <summary>
        /// Test Readycheck
        /// </summary>
        [Test]
        public void ReadycheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Readycheck();
            
        }
        
        /// <summary>
        /// Test UpdateReleaseId
        /// </summary>
        [Test]
        public void UpdateReleaseIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string body = null;
            //bool? resetBeforeUpdate = null;
            //instance.UpdateReleaseId(containerId, body, resetBeforeUpdate);
            
        }
        
        /// <summary>
        /// Test UpdateScanner
        /// </summary>
        [Test]
        public void UpdateScannerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string containerId = null;
            //string body = null;
            //instance.UpdateScanner(containerId, body);
            
        }
        
    }

}
