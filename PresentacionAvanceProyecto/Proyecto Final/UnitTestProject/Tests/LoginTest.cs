using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Final.Otras;

namespace UnitTestProject.Tests
{
    /// <summary>
    /// En esta clase se hacen los Unit Tests de Login
    /// </summary>
    [TestClass]
    public class LoginTest
    {
        /// <summary>
        /// Este Test debe de tener los credenciales correctos para iniciar sesión.
        /// </summary>
        [TestMethod]
        public void RevisarLogin_CredencialesCorrectos_True()
        {
            //Arrange
            var esperado = true;
            string usuario = "admin";
            string contrasena = "admin";
            MetodosLogin metodosLogin = new MetodosLogin();

            //Act
            var resultado = metodosLogin.RevisarLogin(usuario, contrasena);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }

        /// <summary>
        /// Este Test debe de tener los credenciales incorrectos etnonces no dejaría iniciar sesión.
        /// </summary>
        [TestMethod]
        public void RevisarLogin_CredencialesIncorrectos_False()
        {
            //Arrange
            var esperado = false;
            string usuario = "admin";
            string contrasena = "entrar";
            MetodosLogin metodosLogin = new MetodosLogin();

            //Act
            var resultado = metodosLogin.RevisarLogin(usuario, contrasena);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }
    }
}
