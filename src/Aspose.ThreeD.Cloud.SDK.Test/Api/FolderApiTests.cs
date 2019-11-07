/* 
 * Aspose.ThreeD Cloud API Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.0
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

using Aspose.ThreeD.Cloud.SDK.Client;
using Aspose.ThreeD.Cloud.SDK.Api;
using Aspose.ThreeD.Cloud.SDK.Model;

namespace Aspose.ThreeD.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing FolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FolderApiTests :ThreeDBaseTest
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }
       
        /// <summary>
        /// Copy the folder and the files in which to the dest 
        /// </summary>
        [Test]
        public void CopyFolderTest()
        {
            string srcPath = "3DTest";
            string destPath = "3DTestCOPY";
            string srcStorageName = null;
            string destStorageName = null;
            var response = folderApi.CopyFolderWithHttpInfo(srcPath, destPath, srcStorageName, destStorageName);
            Assert.AreEqual(response.StatusCode, 200);
        }

        /// <summary>
        /// Create a new folder,if the folder is exsits,it will rerurn ok.
        /// </summary>
        [Test]
        public void CreateFolderTest()
        {
            string path = "3DTestCreateNew";
            string storageName = null;
            folderApi.CreateFolder(path, storageName);
            var response = folderApi.CreateFolderWithHttpInfo(path, storageName);
            Assert.AreEqual(response.StatusCode, 200);
        }

        /// <summary>
        /// Delete Folder, if the folder is not empty,it will rerurn error.
        /// if the folder is not exsits which will still return the proper status code
        /// </summary>
        [Test]
        public void DeleteFolderTest()
        {
            string path = "3DTestCreateNew";
            string storageName = null;
            folderApi.CreateFolder(path, storageName);
            var response = folderApi.DeleteFolderWithHttpInfo(path, storageName);
            Assert.AreEqual(response.StatusCode, 200);
        }

        /// <summary>
        /// Get the files list in the specified folder,if the folder is not exsits still return the proper status code
        /// </summary>
        [Test]
        public void GetFilesListTest()
        {
            string path = "3DTestCOPY";
            string storageName = null;
            var response = folderApi.GetFilesList(path, storageName);
            Assert.IsInstanceOf<FilesList> (response, "response is FilesList");
        }

        /// <summary>
        /// Move all the files in srcPath to the destPath folder, and delete the srcPath folder
        /// if the source folder is not exsits,the result still return the proper status code 
        /// </summary>
        [Test]
        public void MoveFolderTest()
        {
            string srcPath = "3DTestCOPY";
            string destPath = "3DTestDest";
            string srcStorageName = null;
            string destStorageName = null;
            var response = folderApi.MoveFolderWithHttpInfo(srcPath, destPath, srcStorageName, destStorageName);
            Assert.AreEqual(response.StatusCode, 200);
        }
        
    }

}