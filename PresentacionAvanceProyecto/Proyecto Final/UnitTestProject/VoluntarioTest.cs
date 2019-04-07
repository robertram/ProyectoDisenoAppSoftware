using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Final;

namespace UnitTestProject
{
    /// <summary>
    /// En esta clase se hacen los Unit Test de la clase voluntario.
    /// </summary>
    [TestClass]
    public class VoluntarioTest
    {
        /// <summary>
        /// En este Test se pasa la información correcta para validar al volutario
        /// </summary>
        [TestMethod]
        public void ValidarConObjeto_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            Voluntario voluntario = new Voluntario("Aaron", "Arias", "Hernandez", "83205050", "Ingeniero Civil", "Sabana, SJO.", "aah@gmail.com", "Mensual", "Economica");

            //Act
            var resultado = voluntario.ValidarConObjeto(voluntario);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        /// <summary>
        /// En este Test se pasa la información incorrecta entonces no valida al volutario
        /// </summary>
        [TestMethod]
        public void ValidarConObjeto_InformacionIncorrecta_False()
        {
            //Arrange
            var esperado = false;
            Voluntario voluntario = new Voluntario("Aaron", null, "Hernandez", "83205050", "Ingeniero Civil", "Sabana, SJO.", "aah@gmail.com", "Mensual", "Economica");

            //Act
            var resultado = voluntario.ValidarConObjeto(voluntario);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        /// <summary>
        /// En este método se prueba el método de voluntario para agregar los datos de la persona.
        /// En este se le pasan los datos correctos. El método retornaría True.
        /// </summary>
        [TestMethod]
        public void AgregarDatosPersona_DatosCorrectos_True()
        {
            //Arrange
            var esperado = true;
            Voluntario voluntario = new Voluntario("Gabriel", "Jimenez", "Jimenez", "71040250", "Profesor", "Barva, HER.", "gjj@gmail.com", "Anual", "Economica");

            //Act
            var resultado = voluntario.Agregar_DatosPersona(voluntario);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
