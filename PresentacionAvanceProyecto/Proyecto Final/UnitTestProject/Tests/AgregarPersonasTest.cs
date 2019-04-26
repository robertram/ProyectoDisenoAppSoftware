using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Final.Personas;
using Proyecto_Final.SQL;

namespace UnitTestProject.Tests
{
    [TestClass]
    public class AgregarPersonasTest
    {
        [TestMethod]
        public void AgregarPadrino_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();
            Persona padrino = cliente.CrearPadrino("117790719", "2019-02-12", "Rolando", "Leon", "Gamboa", "62681875", "Torero", "Santo Tomas", "rgleon2010@gmail.com", "Mensual", "En especie");

            //Act
            var resultado = agregar.AgregarPadrino(padrino, proxy);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AgregarNino_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();
            Persona nino = cliente.CrearNino("117460027", "Josue", "Jimenez", "Gomez", "61745528", "Santa Ana", "jjimenezg027@ulacit.ed.cr", "2019-02-10");

            //Act
            var resultado = agregar.AgregarNino(nino, proxy);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AgregarEncargado_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();
            Persona encargado = cliente.CrearEncargadoNino("2019-02-10", "410209014", "Luis", "Barboza", "Blanco", "85241014", "Cajero", "Santa Ana", "lbb@masxmenos.com");

            //Act
            var resultado = agregar.AgregarEncargadoNino(encargado, proxy);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AgregarVoluntario_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();
            Persona voluntario = cliente.CrearVoluntario("117250594", "2018-10-04", "Steven", "Hernandez", "Guadamuz", "84571245", "Cirujano Plastico", "Desampa", "Trimestral", "Economica", "gmail@hotmail.net");

            //Act
            var resultado = agregar.AgregarVoluntario(voluntario, proxy);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AgregarPatrocinador_InformacionCorrecta_True()
        {
            //Arrange
            var esperado = true;
            AgregarPersona agregar = new AgregarPersona();
            Proxy proxy = new Proxy();
            ClienteDePersonas cliente = new ClienteDePersonas();
            Persona patrocinador = cliente.CrearPatrocinador("1999-02-04", "HP", "Tecnologia", "Patrocinadores en especie", "0124578", "Ricardo", "Milos", "Dota", "69420666", "hehe@eo.org");

            //Act
            var resultado = agregar.AgregarPatrocinador(patrocinador, proxy);

            //Assert
            Assert.AreEqual(resultado, esperado);
        }
    }
}
